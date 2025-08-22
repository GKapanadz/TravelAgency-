namespace TravelAgencyAPP
{
    partial class EditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditUserForm));
            lblName = new Label();
            txtBoxName = new TextBox();
            lblUserRole = new Label();
            cbUserRole = new ComboBox();
            btnEdit = new Button();
            btnCancel = new Button();
            lblPassword = new Label();
            txtBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(24, 39);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 38);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(174, 47);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(155, 27);
            txtBoxName.TabIndex = 3;
            // 
            // lblUserRole
            // 
            lblUserRole.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblUserRole.Location = new Point(24, 101);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(126, 38);
            lblUserRole.TabIndex = 4;
            lblUserRole.Text = "User Role";
            lblUserRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbUserRole
            // 
            cbUserRole.FormattingEnabled = true;
            cbUserRole.Location = new Point(174, 109);
            cbUserRole.Name = "cbUserRole";
            cbUserRole.Size = new Size(155, 28);
            cbUserRole.TabIndex = 11;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(46, 267);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(107, 50);
            btnEdit.TabIndex = 12;
            btnEdit.Text = " Save";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(199, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(107, 50);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblPassword
            // 
            lblPassword.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblPassword.Location = new Point(24, 165);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 38);
            lblPassword.TabIndex = 14;
            lblPassword.Text = "Password";
            lblPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(174, 173);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(155, 27);
            txtBoxPassword.TabIndex = 15;
            // 
            // EditUserForm
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 342);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(cbUserRole);
            Controls.Add(lblUserRole);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "EditUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtBoxName;
        private Label lblUserRole;
        private ComboBox cbUserRole;
        private Button btnEdit;
        private Button btnCancel;
        private Label lblPassword;
        private TextBox txtBoxPassword;
    }
}