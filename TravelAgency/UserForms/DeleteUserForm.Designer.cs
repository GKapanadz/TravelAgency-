namespace TravelAgencyAPP
{
    partial class DeleteUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteUserForm));
            btnDelete = new Button();
            btnCancel = new Button();
            lblMessage = new Label();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(82, 138);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 50);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(260, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(45, 38);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(401, 34);
            lblMessage.TabIndex = 10;
            // 
            // DeleteUserForm
            // 
            AcceptButton = btnCancel;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 240);
            Controls.Add(lblMessage);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteUserForm";
            Text = "Delete User";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDelete;
        private Button btnCancel;
        private Label lblMessage;
    }
}