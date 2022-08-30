namespace Converter.MawaCustom
{
    partial class ConvertorByConnectionStringForm
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
            this.ConnectionString_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSQLitePath = new System.Windows.Forms.TextBox();
            this.btnBrowseSQLitePath = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pbrProgress = new System.Windows.Forms.ProgressBar();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbxEncrypt = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cbxTriggers = new System.Windows.Forms.CheckBox();
            this.lnkMessage = new System.Windows.Forms.LinkLabel();
            this.TestConnection_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Database Connection:";
            // 
            // ConnectionString_TextBox
            // 
            this.ConnectionString_TextBox.Location = new System.Drawing.Point(385, 43);
            this.ConnectionString_TextBox.Margin = new System.Windows.Forms.Padding(8);
            this.ConnectionString_TextBox.Multiline = true;
            this.ConnectionString_TextBox.Name = "ConnectionString_TextBox";
            this.ConnectionString_TextBox.Size = new System.Drawing.Size(776, 150);
            this.ConnectionString_TextBox.TabIndex = 1;
            this.ConnectionString_TextBox.TextChanged += new System.EventHandler(this.txtSqlAddress_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.txtSQLitePath.Margin = new System.Windows.Forms.Padding(8);
            this.txtSQLitePath.Name = "txtSQLitePath";
            this.txtSQLitePath.Size = new System.Drawing.Size(776, 40);
            this.txtSQLitePath.TabIndex = 11;
            this.txtSQLitePath.TextChanged += new System.EventHandler(this.txtSQLitePath_TextChanged);
            // 
            // btnBrowseSQLitePath
            // 
            this.btnBrowseSQLitePath.Location = new System.Drawing.Point(1180, 246);
            this.btnBrowseSQLitePath.Margin = new System.Windows.Forms.Padding(8);
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
            this.btnStart.Location = new System.Drawing.Point(428, 548);
            this.btnStart.Margin = new System.Windows.Forms.Padding(8);
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
            // pbrProgress
            // 
            this.pbrProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbrProgress.Location = new System.Drawing.Point(30, 495);
            this.pbrProgress.Margin = new System.Windows.Forms.Padding(8);
            this.pbrProgress.Name = "pbrProgress";
            this.pbrProgress.Size = new System.Drawing.Size(1322, 46);
            this.pbrProgress.TabIndex = 16;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnCancel.Location = new System.Drawing.Point(1115, 548);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8);
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
            this.cbxEncrypt.Location = new System.Drawing.Point(38, 322);
            this.cbxEncrypt.Margin = new System.Windows.Forms.Padding(8);
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
            this.txtPassword.Margin = new System.Windows.Forms.Padding(8);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(296, 40);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // cbxTriggers
            // 
            this.cbxTriggers.AutoSize = true;
            this.cbxTriggers.Location = new System.Drawing.Point(38, 383);
            this.cbxTriggers.Margin = new System.Windows.Forms.Padding(8);
            this.cbxTriggers.Name = "cbxTriggers";
            this.cbxTriggers.Size = new System.Drawing.Size(500, 37);
            this.cbxTriggers.TabIndex = 19;
            this.cbxTriggers.Text = "Create triggers enforcing foreign keys";
            this.cbxTriggers.UseVisualStyleBackColor = true;
            // 
            // lnkMessage
            // 
            this.lnkMessage.AutoSize = true;
            this.lnkMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lnkMessage.Location = new System.Drawing.Point(928, 383);
            this.lnkMessage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lnkMessage.Name = "lnkMessage";
            this.lnkMessage.Size = new System.Drawing.Size(406, 32);
            this.lnkMessage.TabIndex = 20;
            this.lnkMessage.TabStop = true;
            this.lnkMessage.Text = "A message from the author...";
            this.lnkMessage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkMessage_LinkClicked);
            // 
            // TestConnection_Btn
            // 
            this.TestConnection_Btn.Font = new System.Drawing.Font("Tahoma", 6F);
            this.TestConnection_Btn.Location = new System.Drawing.Point(1180, 83);
            this.TestConnection_Btn.Name = "TestConnection_Btn";
            this.TestConnection_Btn.Size = new System.Drawing.Size(188, 72);
            this.TestConnection_Btn.TabIndex = 21;
            this.TestConnection_Btn.Text = "Test Connection";
            this.TestConnection_Btn.UseVisualStyleBackColor = true;
            this.TestConnection_Btn.Click += new System.EventHandler(this.TestConnection_Btn_Click);
            // 
            // ConvertorByConnectionStringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 614);
            this.Controls.Add(this.TestConnection_Btn);
            this.Controls.Add(this.lnkMessage);
            this.Controls.Add(this.cbxTriggers);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cbxEncrypt);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pbrProgress);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnBrowseSQLitePath);
            this.Controls.Add(this.txtSQLitePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConnectionString_TextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "ConvertorByConnectionStringForm";
            this.Text = "SQL Server To SQLite DB Converter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConnectionString_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSQLitePath;
        private System.Windows.Forms.Button btnBrowseSQLitePath;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ProgressBar pbrProgress;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbxEncrypt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox cbxTriggers;
        private System.Windows.Forms.LinkLabel lnkMessage;
        private System.Windows.Forms.Button TestConnection_Btn;
    }
}

