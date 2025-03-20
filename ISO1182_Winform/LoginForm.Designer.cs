namespace ISO1182_Winform
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUserName = new Label();
            lblPasswd = new Label();
            txtPasswd = new TextBox();
            cmbUserType = new ComboBox();
            btnLogin = new Button();
            lblChangePasswd = new LinkLabel();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(80, 30);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(73, 20);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "用户类型:";
            // 
            // lblPasswd
            // 
            lblPasswd.AutoSize = true;
            lblPasswd.Location = new Point(80, 82);
            lblPasswd.Name = "lblPasswd";
            lblPasswd.Size = new Size(73, 20);
            lblPasswd.TabIndex = 2;
            lblPasswd.Text = "登录密码:";
            // 
            // txtPasswd
            // 
            txtPasswd.Location = new Point(172, 79);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.Size = new Size(188, 27);
            txtPasswd.TabIndex = 3;
            // 
            // cmbUserType
            // 
            cmbUserType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUserType.FormattingEnabled = true;
            cmbUserType.Items.AddRange(new object[] { "试验员", "管理员" });
            cmbUserType.Location = new Point(172, 26);
            cmbUserType.Name = "cmbUserType";
            cmbUserType.Size = new Size(188, 28);
            cmbUserType.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(258, 131);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(102, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "登录";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblChangePasswd
            // 
            lblChangePasswd.AutoSize = true;
            lblChangePasswd.Location = new Point(400, 172);
            lblChangePasswd.Name = "lblChangePasswd";
            lblChangePasswd.Size = new Size(69, 20);
            lblChangePasswd.TabIndex = 5;
            lblChangePasswd.TabStop = true;
            lblChangePasswd.Text = "更改密码";
            lblChangePasswd.Click += lblChangePasswd_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 201);
            Controls.Add(lblChangePasswd);
            Controls.Add(btnLogin);
            Controls.Add(cmbUserType);
            Controls.Add(txtPasswd);
            Controls.Add(lblPasswd);
            Controls.Add(lblUserName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "系统登录";
            Load += LoginForm_Load;
            Shown += LoginForm_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPasswd;
        private TextBox txtPasswd;
        private ComboBox cmbUserType;
        private Button btnLogin;
        private LinkLabel lblChangePasswd;
    }
}
