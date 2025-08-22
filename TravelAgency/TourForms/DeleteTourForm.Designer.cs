namespace TravelAgencyAPP
{
    partial class DeleteTourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTourForm));
            lblMessage = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(52, 31);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(401, 34);
            lblMessage.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(277, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(73, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(122, 50);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // DeleteTourForm
            // 
            AcceptButton = btnDelete;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(472, 232);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            Controls.Add(lblMessage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteTourForm";
            Text = "DeleteTour";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessage;
        private Button btnCancel;
        private Button btnDelete;
    }
}