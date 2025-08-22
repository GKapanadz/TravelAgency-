namespace TravelAgencyAPP.CityForms
{
    partial class DeleteCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteCityForm));
            lblMessage = new Label();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Location = new Point(39, 28);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(401, 34);
            lblMessage.TabIndex = 1;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(79, 118);
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
            btnCancel.Location = new Point(277, 118);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 50);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteCityForm
            // 
            AcceptButton = btnDelete;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(486, 228);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(lblMessage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "DeleteCityForm";
            Text = "DeleteCity";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMessage;
        private Button btnDelete;
        private Button btnCancel;
    }
}