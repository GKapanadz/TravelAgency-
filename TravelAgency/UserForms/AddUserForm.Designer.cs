namespace TravelAgencyAPP
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            lblUserName = new Label();
            lblPassword = new Label();
            lblUserRole = new Label();
            btnAdd = new Button();
            btnCancel = new Button();
            txtName = new TextBox();
            txtPassword = new TextBox();
            cbUserRole = new ComboBox();
            cbEmployeeId = new ComboBox();
            lblEmployeeName = new Label();
            SuspendLayout();
            // 
            // lblUserName
            // 
            lblUserName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblUserName.Location = new Point(33, 63);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(126, 34);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "Name";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPassword.Location = new Point(33, 121);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 34);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblUserRole.Location = new Point(33, 187);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(126, 34);
            lblUserRole.TabIndex = 2;
            lblUserRole.Text = "User Role";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(61, 334);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add User";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(228, 334);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 51);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(209, 70);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(209, 128);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(172, 27);
            txtPassword.TabIndex = 9;
            // 
            // cbUserRole
            // 
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(209, 193);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(172, 28);
            cbUserRole.TabIndex = 10;
            // 
            // cbEmployeeId
            // 
            cbEmployeeId.FormattingEnabled = true;
            cbEmployeeId.Location = new Point(209, 256);
            cbEmployeeId.Name = "cbEmployeeId";
            cbEmployeeId.Size = new Size(172, 28);
            cbEmployeeId.TabIndex = 11;
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblEmployeeName.Location = new Point(33, 250);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(148, 34);
            lblEmployeeName.TabIndex = 12;
            lblEmployeeName.Text = "Employee Name";
            lblEmployeeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // AddUserForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 413);
            Controls.Add(lblEmployeeName);
            Controls.Add(cbEmployeeId);
            Controls.Add(cbUserRole);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(lblUserRole);
            Controls.Add(lblPassword);
            Controls.Add(lblUserName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUserName;
        private Label lblPassword;
        private Label lblUserRole;
        private Button btnAdd;
        private Button btnCancel;
        private TextBox txtName;
        private TextBox txtPassword;
        private ComboBox cbUserRole;
        private ComboBox cbEmployeeId;
        private Label lblEmployeeName;
    }
}