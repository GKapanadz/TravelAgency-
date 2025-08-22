namespace TravelAgencyAPP
{
    partial class EditTourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTourForm));
            txtBoxName = new TextBox();
            lblName = new Label();
            lblDuration = new Label();
            lblTotalPrice = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            nudDuration = new NumericUpDown();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtTotalPrice = new TextBox();
            btnEdit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // txtBoxName
            // 
            txtBoxName.Location = new Point(229, 67);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(155, 27);
            txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(12, 56);
            lblName.Name = "lblName";
            lblName.Size = new Size(129, 38);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            lblDuration.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDuration.Location = new Point(12, 105);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(129, 38);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "Duration";
            lblDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(12, 158);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(129, 38);
            lblTotalPrice.TabIndex = 3;
            lblTotalPrice.Text = "TotalPrice";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            lblStartDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblStartDate.Location = new Point(12, 214);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(129, 38);
            lblStartDate.TabIndex = 4;
            lblStartDate.Text = "StartDate";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            lblEndDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblEndDate.Location = new Point(12, 270);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(129, 38);
            lblEndDate.TabIndex = 5;
            lblEndDate.Text = "EndDate";
            lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(229, 114);
            nudDuration.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(155, 27);
            nudDuration.TabIndex = 1;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(197, 220);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(197, 270);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(229, 169);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(155, 27);
            txtTotalPrice.TabIndex = 2;
            txtTotalPrice.Text = "0";
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(79, 351);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(122, 50);
            btnEdit.TabIndex = 5;
            btnEdit.Text = " Save";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(262, 351);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(122, 50);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditTourForm
            // 
            AcceptButton = btnEdit;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 449);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(txtTotalPrice);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(nudDuration);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblName);
            Controls.Add(txtBoxName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "EditTourForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTour";
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxName;
        private Label lblName;
        private Label lblDuration;
        private Label lblTotalPrice;
        private Label lblStartDate;
        private Label lblEndDate;
        private NumericUpDown nudDuration;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtTotalPrice;
        private Button btnEdit;
        private Button btnCancel;
    }
}