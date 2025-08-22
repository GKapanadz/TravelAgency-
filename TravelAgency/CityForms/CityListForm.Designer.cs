namespace TravelAgencyAPP.CityForms
{
    partial class CityListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityListForm));
            CityDataGridView = new DataGridView();
            txtSearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)CityDataGridView).BeginInit();
            SuspendLayout();
            // 
            // CityDataGridView
            // 
            CityDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CityDataGridView.Dock = DockStyle.Fill;
            CityDataGridView.Location = new Point(0, 0);
            CityDataGridView.Name = "CityDataGridView";
            CityDataGridView.RowHeadersWidth = 51;
            CityDataGridView.Size = new Size(922, 391);
            CityDataGridView.TabIndex = 0;
            // 
            // txtSearchBar
            // 
            txtSearchBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtSearchBar.Location = new Point(797, 334);
            txtSearchBar.Name = "txtSearchBar";
            txtSearchBar.Size = new Size(125, 27);
            txtSearchBar.TabIndex = 6;
            txtSearchBar.Text = "Search Bar";
            txtSearchBar.Enter += txtSearchBar_Enter;
            txtSearchBar.KeyDown += txtCitiesSearchBar_KeyDown;
            // 
            // CityListForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 391);
            Controls.Add(txtSearchBar);
            Controls.Add(CityDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CityListForm";
            Text = "CityList";
            ((System.ComponentModel.ISupportInitialize)CityDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CityDataGridView;
        private TextBox txtSearchBar;
    }
}