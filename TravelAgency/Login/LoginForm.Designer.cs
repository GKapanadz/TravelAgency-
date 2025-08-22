namespace TravelAgencyAPP
{
    partial class LoginForm
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
            lbl_Username = new Label();
            lbl_Password = new Label();
            txt_Password = new TextBox();
            txt_Username = new TextBox();
            btn_Login = new Button();
            btn_Cancel = new Button();
            SuspendLayout();
            // 
            // lbl_Username
            // 
            lbl_Username.Font = new Font("Segoe UI Variable Small Semibol", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Username.Location = new Point(12, 20);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(112, 25);
            lbl_Username.TabIndex = 0;
            lbl_Username.Text = "Username";
            lbl_Username.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            lbl_Password.Font = new Font("Segoe UI Variable Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Password.Location = new Point(12, 53);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(112, 25);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            lbl_Password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(158, 55);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(283, 27);
            txt_Password.TabIndex = 1;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(158, 22);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(283, 27);
            txt_Username.TabIndex = 0;
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(235, 97);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(95, 31);
            btn_Login.TabIndex = 2;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(346, 97);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(95, 31);
            btn_Cancel.TabIndex = 3;
            btn_Cancel.Text = "Cancel";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += btn_Cancel_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btn_Login;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_Cancel;
            ClientSize = new Size(463, 138);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Login);
            Controls.Add(txt_Username);
            Controls.Add(txt_Password);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_Username);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Username;
        private Label lbl_Password;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Login;
        private Button btn_Cancel;
    }
}