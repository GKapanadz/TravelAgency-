namespace TravelAgencyAPP
{
    partial class AddTourForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTourForm));
            lblName = new Label();
            lblDuration = new Label();
            lblTotalPrice = new Label();
            lblStartDate = new Label();
            lblEndDate = new Label();
            txtName = new TextBox();
            nudDuration = new NumericUpDown();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtTotalPrice = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblName.Location = new Point(33, 46);
            lblName.Name = "lblName";
            lblName.Size = new Size(136, 42);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDuration
            // 
            lblDuration.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblDuration.Location = new Point(33, 103);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(136, 42);
            lblDuration.TabIndex = 1;
            lblDuration.Text = "Duration";
            lblDuration.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(33, 155);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(136, 42);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "TotalPrice";
            lblTotalPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStartDate
            // 
            lblStartDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblStartDate.Location = new Point(33, 213);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(136, 42);
            lblStartDate.TabIndex = 3;
            lblStartDate.Text = "StartDate";
            lblStartDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEndDate
            // 
            lblEndDate.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblEndDate.Location = new Point(33, 269);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(136, 42);
            lblEndDate.TabIndex = 4;
            lblEndDate.Text = "EndDate";
            lblEndDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            txtName.Location = new Point(233, 61);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 0;
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(233, 114);
            nudDuration.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(172, 27);
            nudDuration.TabIndex = 1;
            nudDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(208, 228);
            dtpStartDate.MinDate = new DateTime(2025, 5, 31, 0, 0, 0, 0);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(208, 277);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(250, 27);
            dtpEndDate.TabIndex = 4;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(233, 165);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(172, 27);
            txtTotalPrice.TabIndex = 2;
            txtTotalPrice.Text = "0";
            txtTotalPrice.Enter += txtTotalPrice_Enter;
            txtTotalPrice.KeyPress += txtTotalPrice_KeyPress;
            txtTotalPrice.Leave += txtTotalPrice_Leave;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(69, 342);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 51);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Tour";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(263, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 51);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddTourForm
            // 
            AcceptButton = btnAdd;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalPrice);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(nudDuration);
            Controls.Add(txtName);
            Controls.Add(lblEndDate);
            Controls.Add(lblStartDate);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblDuration);
            Controls.Add(lblName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "AddTourForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddTour";
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDuration;
        private Label lblTotalPrice;
        private Label lblStartDate;
        private Label lblEndDate;
        private TextBox txtName;
        private NumericUpDown nudDuration;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private TextBox txtTotalPrice;
        private Button btnAdd;
        private Button btnCancel;
    }
}