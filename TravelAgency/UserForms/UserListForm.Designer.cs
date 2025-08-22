namespace TravelAgencyAPP
{
    partial class UserListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListForm));
            dataGridViewUser = new DataGridView();
            UserName = new DataGridViewTextBoxColumn();
            UserRole = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            CreateDate = new DataGridViewTextBoxColumn();
            txtSearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Columns.AddRange(new DataGridViewColumn[] { UserName, UserRole, IsActive, CreateDate });
            dataGridViewUser.Dock = DockStyle.Fill;
            dataGridViewUser.Location = new Point(0, 0);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 51;
            dataGridViewUser.Size = new Size(660, 381);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellFormatting += dataGridViewUser_CellFormatting;
            // 
            // UserName
            // 
            UserName.HeaderText = "Name";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            UserName.Width = 125;
            // 
            // UserRole
            // 
            UserRole.HeaderText = "Role";
            UserRole.MinimumWidth = 6;
            UserRole.Name = "UserRole";
            UserRole.Width = 125;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "Active";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.Width = 125;
            // 
            // CreateDate
            // 
            CreateDate.HeaderText = "Create Date";
            CreateDate.MinimumWidth = 6;
            CreateDate.Name = "CreateDate";
            CreateDate.Width = 125;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Location = new Point(518, 342);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(125, 27);
            txtSearchBar.TabIndex = 6;
            txtSearchBar.Text = "Search Bar";
            txtSearchBar.Click += txtSearchBar_Click;
            txtSearchBar.KeyDown += txtSearchBar_KeyDown;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 381);
            Controls.Add(txtSearchBar);
            Controls.Add(dataGridViewUser);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "UserListForm";
            Text = "UserList";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUser;
        private DataGridViewTextBoxColumn UserName;
        private DataGridViewTextBoxColumn UserRole;
        private TextBox txtSearchBar;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreateDate;
    }
}