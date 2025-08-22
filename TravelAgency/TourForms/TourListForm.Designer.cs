namespace TravelAgencyAPP
{
    partial class TourListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TourListForm));
            dataGridView = new DataGridView();
            TourName = new DataGridViewTextBoxColumn();
            Duration = new DataGridViewTextBoxColumn();
            TotalPrice = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            txtSearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { TourName, Duration, TotalPrice, StartDate, EndDate, IsActive });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(0, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(994, 424);
            dataGridView.TabIndex = 3;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // TourName
            // 
            TourName.HeaderText = "Name";
            TourName.MinimumWidth = 6;
            TourName.Name = "TourName";
            TourName.Width = 125;
            // 
            // Duration
            // 
            Duration.HeaderText = "Duration";
            Duration.MinimumWidth = 6;
            Duration.Name = "Duration";
            Duration.Width = 125;
            // 
            // TotalPrice
            // 
            TotalPrice.HeaderText = "TotalPrice";
            TotalPrice.MinimumWidth = 6;
            TotalPrice.Name = "TotalPrice";
            TotalPrice.Width = 125;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "StartDate";
            StartDate.MinimumWidth = 6;
            StartDate.Name = "StartDate";
            StartDate.Width = 125;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "EndDate";
            EndDate.MinimumWidth = 6;
            EndDate.Name = "EndDate";
            EndDate.Width = 125;
            // 
            // IsActive
            // 
            IsActive.HeaderText = "ActiveTour";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            IsActive.Width = 125;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearchBar.Location = new Point(869, 359);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(125, 27);
            txtSearchBar.TabIndex = 5;
            txtSearchBar.Text = "Search Bar";
            txtSearchBar.Enter += txtSearchBar_Enter;
            txtSearchBar.KeyDown += txtSearchBar_KeyDown;
            // 
            // TourListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(994, 424);
            Controls.Add(txtSearchBar);
            Controls.Add(dataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TourListForm";
            Text = "TourList";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private TextBox txtSearchBar;
        private DataGridViewTextBoxColumn TourName;
        private DataGridViewTextBoxColumn Duration;
        private DataGridViewTextBoxColumn TotalPrice;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn IsActive;
    }
}