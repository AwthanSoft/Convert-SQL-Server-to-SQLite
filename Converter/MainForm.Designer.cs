namespace Converter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSqlAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLitePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSQLitePath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDatabases = new System.Windows.Forms.ComboBox();
            this.btnSet = new System.Windows.Forms.Button();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxEncrypt = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbxIntegrated = new System.Windows.Forms.CheckBox();
            this.txtUserDB = new System.Windows.Forms.TextBox();
            this.txtPassDB = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.cbxTriggers = new System.Windows.Forms.CheckBox();
            this.cbxCreateViews = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "SQL Server Address:";
            // 
            // txtSqlAddress
            // 
            this.txtSqlAddress.Location = new System.Drawing.Point(385, 43);
            this.txtSqlAddress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtSqlAddress.Name = "txtSqlAddress";
            this.txtSqlAddress.Size = new System.Drawing.Size(1066, 40);
            this.txtSqlAddress.TabIndex = 1;
            this.txtSqlAddress.TextChanged += new System.EventHandler(this.txtSqlAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(30, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "SQLite Database File Path:";
            // 
            // txtSQLitePath
            // 
            this.txtSQLitePath.Location = new System.Drawing.Point(385, 249);
            this.txtSQLitePath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtSQLitePath.Name = "txtSQLitePath";
            this.txtSQLitePath.Size = new System.Drawing.Size(1066, 40);
            this.txtSQLitePath.TabIndex = 11;
            this.txtSQLitePath.TextChanged += new System.EventHandler(this.txtSQLitePath_TextChanged);
            // 
            // btnBrowseSQLitePath
            // 
            this.btnBrowseSQLitePath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowseSQLitePath.Location = new System.Drawing.Point(1472, 244);
            this.btnBrowseSQLitePath.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnBrowseSQLitePath.Name = "btnBrowseSQLitePath";
            this.btnBrowseSQLitePath.Size = new System.Drawing.Size(188, 58);
            this.btnBrowseSQLitePath.TabIndex = 12;
            this.btnBrowseSQLitePath.Text = "Browse...";
            this.btnBrowseSQLitePath.UseVisualStyleBackColor = true;
            this.btnBrowseSQLitePath.Click += new System.EventHandler(this.btnBrowseSQLitePath_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(912, 548);
            this.btnStart.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(495, 58);
            this.btnStart.TabIndex = 17;
            this.btnStart.Text = "Start The Conversion Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "db";
            this.saveFileDialog1.Filter = "SQLite Files|*.db|All Files|*.*";
            this.saveFileDialog1.RestoreDirectory = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(30, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Select DB:";
            // 
            // cboDatabases
            // 
            this.cboDatabases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDatabases.Enabled = false;
            this.cboDatabases.FormattingEnabled = true;
            this.cboDatabases.Location = new System.Drawing.Point(385, 109);
            this.cboDatabases.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cboDatabases.Name = "cboDatabases";
            this.cboDatabases.Size = new System.Drawing.Size(1066, 41);
            this.cboDatabases.TabIndex = 4;
            this.cboDatabases.SelectedIndexChanged += new System.EventHandler(this.cboDatabases_SelectedIndexChanged);
            // 
            // btnSet
            // 
            this.btnSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSet.Location = new System.Drawing.Point(1472, 38);
            this.btnSet.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(188, 58);
            this.btnSet.TabIndex = 2;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrProgress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pbrProgress.Location = new System.Drawing.Point(30, 495);
            this.pbrProgress.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(1630, 46);
            this.pbrProgress.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMessage.Location = new System.Drawing.Point(30, 449);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1322, 33);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCancel.Location = new System.Drawing.Point(1422, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 58);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbxEncrypt
            // 
            this.cbxEncrypt.AutoSize = true;
            this.cbxEncrypt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxEncrypt.Location = new System.Drawing.Point(38, 322);
            this.cbxEncrypt.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbxEncrypt.Name = "cbxEncrypt";
            this.cbxEncrypt.Size = new System.Drawing.Size(309, 37);
            this.cbxEncrypt.TabIndex = 13;
            this.cbxEncrypt.Text = "Encryption password:";
            this.cbxEncrypt.UseVisualStyleBackColor = true;
            this.cbxEncrypt.CheckedChanged += new System.EventHandler(this.cbxEncrypt_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(385, 317);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(486, 40);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbxIntegrated
            // 
            this.cbxIntegrated.Checked = true;
            this.cbxIntegrated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxIntegrated.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxIntegrated.Location = new System.Drawing.Point(38, 180);
            this.cbxIntegrated.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbxIntegrated.Name = "cbxIntegrated";
            this.cbxIntegrated.Size = new System.Drawing.Size(325, 53);
            this.cbxIntegrated.TabIndex = 5;
            this.cbxIntegrated.Text = "Integrated security";
            this.cbxIntegrated.UseVisualStyleBackColor = true;
            this.cbxIntegrated.CheckedChanged += new System.EventHandler(this.ChkIntegratedCheckedChanged);
            // 
            // txtUserDB
            // 
            this.txtUserDB.Location = new System.Drawing.Point(472, 180);
            this.txtUserDB.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtUserDB.Name = "txtUserDB";
            this.txtUserDB.Size = new System.Drawing.Size(244, 40);
            this.txtUserDB.TabIndex = 7;
            this.txtUserDB.Visible = false;
            // 
            // txtPassDB
            // 
            this.txtPassDB.Location = new System.Drawing.Point(885, 180);
            this.txtPassDB.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.txtPassDB.Name = "txtPassDB";
            this.txtPassDB.PasswordChar = '*';
            this.txtPassDB.Size = new System.Drawing.Size(276, 40);
            this.txtPassDB.TabIndex = 9;
            this.txtPassDB.Visible = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblUser.Location = new System.Drawing.Point(378, 188);
            this.lblUser.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 33);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User:";
            this.lblUser.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPassword.Location = new System.Drawing.Point(738, 188);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(138, 33);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Visible = false;
            // 
            // cbxTriggers
            // 
            this.cbxTriggers.AutoSize = true;
            this.cbxTriggers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxTriggers.Location = new System.Drawing.Point(38, 383);
            this.cbxTriggers.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbxTriggers.Name = "cbxTriggers";
            this.cbxTriggers.Size = new System.Drawing.Size(500, 37);
            this.cbxTriggers.TabIndex = 19;
            this.cbxTriggers.Text = "Create triggers enforcing foreign keys";
            this.cbxTriggers.UseVisualStyleBackColor = true;
            // 
            // cbxCreateViews
            // 
            this.cbxCreateViews.AutoSize = true;
            this.cbxCreateViews.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbxCreateViews.Location = new System.Drawing.Point(555, 383);
            this.cbxCreateViews.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.cbxCreateViews.Name = "cbxCreateViews";
            this.cbxCreateViews.Size = new System.Drawing.Size(618, 37);
            this.cbxCreateViews.TabIndex = 20;
            this.cbxCreateViews.Text = "Try to create views (works only in simple cases)";
            this.cbxCreateViews.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1690, 614);
            this.Controls.Add(this.cbxCreateViews);
            this.Controls.Add(this.cbxTriggers);
            this.Controls.Add(this.txtPassDB);
            this.Controls.Add(this.txtUserDB);
            this.Controls.Add(this.cbxIntegrated);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbxEncrypt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.cboDatabases);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseSQLitePath);
            this.Controls.Add(this.txtSQLitePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSqlAddress);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SQL Server To SQLite DB Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtPassDB;
        private System.Windows.Forms.TextBox txtUserDB;
        private System.Windows.Forms.CheckBox cbxIntegrated;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSqlAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLitePath;
        private System.Windows.Forms.Button btnBrowseSQLitePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDatabases;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxTriggers;
        private System.Windows.Forms.CheckBox cbxCreateViews;
    }
}

