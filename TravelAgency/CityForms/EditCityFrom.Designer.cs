namespace TravelAgencyAPP.CityForms
{
    partial class EditCityFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCityFrom));
            lblName = new Label();
            lblCountry = new Label();
            txtBoxName = new TextBox();
            cmbCountry = new ComboBox();
            btnEdit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(47, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 42);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCountry
            // 
            lblCountry.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCountry.Location = new Point(47, 150);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 42);
            lblCountry.TabIndex = 4;
            lblCountry.Text = "Country";
            lblCountry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(216, 80);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(172, 27);
            txtBoxName.TabIndex = 5;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(216, 160);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(172, 28);
            cmbCountry.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(47, 254);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(142, 51);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Save";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(235, 254);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 51);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditCityFrom
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(446, 356);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(cmbCountry);
            Controls.Add(txtBoxName);
            Controls.Add(lblCountry);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditCityFrom";
            Text = "EditCity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblCountry;
        private TextBox txtBoxName;
        private ComboBox cmbCountry;
        private Button btnEdit;
        private Button btnCancel;
    }
}