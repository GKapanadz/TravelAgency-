namespace TravelAgencyAPP.CityForms
{
    partial class AddCityForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCityForm));
            lblName = new Label();
            txtBoxName = new TextBox();
            lblCountry = new Label();
            cmbCountry = new ComboBox();
            btnAdd = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(40, 69);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 42);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(245, 79);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(172, 27);
            txtBoxName.TabIndex = 2;
            // 
            // lblCountry
            // 
            lblCountry.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblCountry.Location = new Point(40, 130);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(136, 42);
            lblCountry.TabIndex = 3;
            lblCountry.Text = "Country";
            lblCountry.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbCountry
            // 
            cmbCountry.FormattingEnabled = true;
            cmbCountry.Location = new Point(245, 140);
            cmbCountry.Name = "cmbCountry";
            cmbCountry.Size = new Size(172, 28);
            cmbCountry.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(71, 203);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 51);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add City";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(260, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 51);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCityForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 307);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cmbCountry);
            Controls.Add(lblCountry);
            Controls.Add(txtBoxName);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddCityForm";
            Text = "AddCity";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtBoxName;
        private Label lblCountry;
        private ComboBox cmbCountry;
        private Button btnAdd;
        private Button btnCancel;
    }
}