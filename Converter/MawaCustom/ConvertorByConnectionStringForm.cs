using DbAccess;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace Converter.MawaCustom
{
    public partial class ConvertorByConnectionStringForm : Form
    {
        #region Constructor
        string ConnectionString => this.ConnectionString_TextBox.Text;
        public ConvertorByConnectionStringForm(string ConnectionString)
        {
            //this.ConnectionString = ConnectionString;
            InitializeComponent();
            this.ConnectionString_TextBox.Text = ConnectionString;
        }
        #endregion

        #region Event Handler
        private void btnBrowseSQLitePath_Click(object sender, EventArgs e)
        {
            DialogResult res = saveFileDialog1.ShowDialog(this);
            if (res == DialogResult.Cancel)
                return;

            string fpath = saveFileDialog1.FileName;
            txtSQLitePath.Text = fpath;
            pbrProgress.Value = 0;
            lblMessage.Text = string.Empty;
        }

        private void txtSQLitePath_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateSensitivity();

            string version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.Text = "SQL Server To SQLite DB Converter (" + version + ")";
        }

        private void txtSqlAddress_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SqlServerToSQLite.CancelConversion();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SqlServerToSQLite.IsActive)
            {
                SqlServerToSQLite.CancelConversion();
                _shouldExit = true;
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        private void cbxEncrypt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateSensitivity();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!TestConnection(ConnectionString, out Exception ex))
            {
                MessageBox.Show(this,
                    ex.Message,
                    "Failed To Connect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                UpdateSensitivity();
                return;
            }

            string sqlConnString = this.ConnectionString;

            string sqlitePath = txtSQLitePath.Text.Trim();
            this.Cursor = Cursors.WaitCursor;
            SqlConversionHandler handler = new SqlConversionHandler(delegate (bool done,
                bool success, int percent, string msg)
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    UpdateSensitivity();
                    lblMessage.Text = msg;
                    pbrProgress.Value = percent;

                    if (done)
                    {
                        btnStart.Enabled = true;
                        this.Cursor = Cursors.Default;
                        UpdateSensitivity();

                        if (success)
                        {
                            MessageBox.Show(this,
                                msg,
                                "Conversion Finished",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            pbrProgress.Value = 0;
                            lblMessage.Text = string.Empty;
                        }
                        else
                        {
                            if (!_shouldExit)
                            {
                                MessageBox.Show(this,
                                    msg,
                                    "Conversion Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                                pbrProgress.Value = 0;
                                lblMessage.Text = string.Empty;
                            }
                            else
                                Application.Exit();
                        }
                    }
                }));
            });
            SqlTableSelectionHandler selectionHandler = new SqlTableSelectionHandler(delegate (List<TableSchema> schema)
            {
                List<TableSchema> updated = null;
                Invoke(new MethodInvoker(delegate
                {
                    // Allow the user to select which tables to include by showing him the 
                    // table selection dialog.
                    TableSelectionDialog dlg = new TableSelectionDialog();
                    DialogResult res = dlg.ShowTables(schema, this);
                    if (res == DialogResult.OK)
                        updated = dlg.IncludedTables;
                }));
                return updated;
            });

            FailedViewDefinitionHandler viewFailureHandler = new FailedViewDefinitionHandler(delegate (ViewSchema vs)
            {
                string updated = null;
                Invoke(new MethodInvoker(delegate
                {
                    ViewFailureDialog dlg = new ViewFailureDialog();
                    dlg.View = vs;
                    DialogResult res = dlg.ShowDialog(this);
                    if (res == DialogResult.OK)
                        updated = dlg.ViewSQL;
                    else
                        updated = null;
                }));

                return updated;
            });

            string password = txtPassword.Text.Trim();
            if (!cbxEncrypt.Checked)
                password = null;
            SqlServerToSQLite.ConvertSqlServerToSQLiteDatabase(sqlConnString, sqlitePath, password, handler,
                selectionHandler, viewFailureHandler, cbxTriggers.Checked);
        }

        private void lnkMessage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AuthorMessageForm frm = new AuthorMessageForm();
            frm.ShowDialog(this);
        }

        #endregion

        #region Private Methods
        private void UpdateSensitivity()
        {
            if (txtSQLitePath.Text.Trim().Length > 0 && ConnectionString_TextBox.Text.Trim().Length > 0 &&
                (!cbxEncrypt.Checked || txtPassword.Text.Trim().Length > 0))
                btnStart.Enabled = true && !SqlServerToSQLite.IsActive;
            else
                btnStart.Enabled = false;

            TestConnection_Btn.Enabled = ConnectionString_TextBox.Text.Trim().Length > 0 && !SqlServerToSQLite.IsActive;
            btnCancel.Visible = SqlServerToSQLite.IsActive;
            ConnectionString_TextBox.Enabled = !SqlServerToSQLite.IsActive;
            txtSQLitePath.Enabled = !SqlServerToSQLite.IsActive;
            btnBrowseSQLitePath.Enabled = !SqlServerToSQLite.IsActive;
            cbxEncrypt.Enabled = !SqlServerToSQLite.IsActive;
            txtPassword.Enabled = cbxEncrypt.Checked && cbxEncrypt.Enabled;
        }


        #endregion

        #region Private Variables
        private bool _shouldExit = false;
        #endregion


        private void TestConnection_Btn_Click(object sender, EventArgs e)
        {
            if (TestConnection(ConnectionString, out Exception ex))
            {
                MessageBox.Show(this, "Successfully connected",
                    "Success To Connect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this,
                    ex.Message,
                    "Failed To Connect",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static string TestConnectionCommand = @"select * 
from INFORMATION_SCHEMA.COLUMNS
where TABLE_NAME='table_name';";
        private static bool TestConnection(string ConnectionString, out Exception ErrorEx)
        {
            bool result = false;
            try
            {
                using (SqlConnection sql_conn = new SqlConnection(ConnectionString))
                {
                    sql_conn.Open();

                    var sql_cmd = sql_conn.CreateCommand();
                    sql_cmd.CommandText = TestConnectionCommand;

                    var sql_datareader = sql_cmd.ExecuteReader();
                    while (sql_datareader.Read())
                    {
                        string myreader = sql_datareader.GetString(0);
                        Console.WriteLine(myreader);
                    }

                    sql_conn.Close();
                } // using

                result = true;
                ErrorEx = null;
            }
            catch (Exception ex)
            {
                ErrorEx = ex;
            } // catch
            return result;
        }
    }
}