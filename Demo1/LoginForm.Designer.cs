namespace Demo1
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
            Login = new Label();
            Passw = new Label();
            txtBox_Login = new TextBox();
            txtBox_Password = new TextBox();
            Enter = new Button();
            lbl_Info = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Location = new Point(12, 29);
            Login.Name = "Login";
            Login.Size = new Size(52, 20);
            Login.TabIndex = 0;
            Login.Text = "Логин";
            // 
            // Passw
            // 
            Passw.AutoSize = true;
            Passw.Location = new Point(12, 86);
            Passw.Name = "Passw";
            Passw.Size = new Size(62, 20);
            Passw.TabIndex = 1;
            Passw.Text = "Пароль";
            // 
            // txtBox_Login
            // 
            txtBox_Login.Location = new Point(96, 29);
            txtBox_Login.Name = "txtBox_Login";
            txtBox_Login.Size = new Size(202, 27);
            txtBox_Login.TabIndex = 2;
            txtBox_Login.TextChanged += txtBox_Login_TextChanged;
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new Point(96, 86);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.PasswordChar = '*';
            txtBox_Password.Size = new Size(202, 27);
            txtBox_Password.TabIndex = 3;
            txtBox_Password.TextChanged += txtBox_Password_TextChanged;
            // 
            // Enter
            // 
            Enter.Location = new Point(204, 139);
            Enter.Name = "Enter";
            Enter.Size = new Size(94, 29);
            Enter.TabIndex = 4;
            Enter.Text = "Войти";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // lbl_Info
            // 
            lbl_Info.Location = new Point(12, 198);
            lbl_Info.MaximumSize = new Size(320, 75);
            lbl_Info.MinimumSize = new Size(320, 75);
            lbl_Info.Name = "lbl_Info";
            lbl_Info.Size = new Size(320, 75);
            lbl_Info.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(360, 344);
            Controls.Add(lbl_Info);
            Controls.Add(Enter);
            Controls.Add(txtBox_Password);
            Controls.Add(txtBox_Login);
            Controls.Add(Passw);
            Controls.Add(Login);
            ForeColor = Color.Black;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Авторизация";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
        private Label Passw;
        private TextBox txtBox_Login;
        private TextBox txtBox_Password;
        private Button Enter;
        private Label lbl_Info;
    }
}
