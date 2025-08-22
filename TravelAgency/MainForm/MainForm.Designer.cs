namespace TravelAgencyAPP
{
    partial class MainForm : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            toursToolStripMenuItem = new ToolStripMenuItem();
            searchTourToolStripMenuItem = new ToolStripMenuItem();
            addTourStripMenuItem = new ToolStripMenuItem();
            editTourToolStripMenuItem = new ToolStripMenuItem();
            deleteTourToolStripMenuItem = new ToolStripMenuItem();
            usersToolStripMenuItem = new ToolStripMenuItem();
            searchUserToolStripMenuItem = new ToolStripMenuItem();
            addUserToolStripMenuItem = new ToolStripMenuItem();
            editUserToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            citiesToolStripMenuItem1 = new ToolStripMenuItem();
            searchCitiesToolStripMenuItem = new ToolStripMenuItem();
            addCityToolStripMenuItem = new ToolStripMenuItem();
            editCityToolStripMenuItem = new ToolStripMenuItem();
            deleteCityToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toursToolStripMenuItem, usersToolStripMenuItem, citiesToolStripMenuItem1 });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // toursToolStripMenuItem
            // 
            toursToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchTourToolStripMenuItem, addTourStripMenuItem, editTourToolStripMenuItem, deleteTourToolStripMenuItem });
            toursToolStripMenuItem.Name = "toursToolStripMenuItem";
            resources.ApplyResources(toursToolStripMenuItem, "toursToolStripMenuItem");
            // 
            // searchTourToolStripMenuItem
            // 
            searchTourToolStripMenuItem.Name = "searchTourToolStripMenuItem";
            resources.ApplyResources(searchTourToolStripMenuItem, "searchTourToolStripMenuItem");
            searchTourToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // addTourStripMenuItem
            // 
            addTourStripMenuItem.Name = "addTourStripMenuItem";
            resources.ApplyResources(addTourStripMenuItem, "addTourStripMenuItem");
            addTourStripMenuItem.Click += addTourStripMenuItem_Click;
            // 
            // editTourToolStripMenuItem
            // 
            editTourToolStripMenuItem.Name = "editTourToolStripMenuItem";
            resources.ApplyResources(editTourToolStripMenuItem, "editTourToolStripMenuItem");
            editTourToolStripMenuItem.Click += editTourToolStripMenuItem_Click;
            // 
            // deleteTourToolStripMenuItem
            // 
            deleteTourToolStripMenuItem.Name = "deleteTourToolStripMenuItem";
            resources.ApplyResources(deleteTourToolStripMenuItem, "deleteTourToolStripMenuItem");
            deleteTourToolStripMenuItem.Click += deleteTourToolStripMenuItem_Click;
            // 
            // usersToolStripMenuItem
            // 
            usersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { searchUserToolStripMenuItem, addUserToolStripMenuItem, editUserToolStripMenuItem, deleteUserToolStripMenuItem });
            usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            resources.ApplyResources(usersToolStripMenuItem, "usersToolStripMenuItem");
            // 
            // searchUserToolStripMenuItem
            // 
            searchUserToolStripMenuItem.Name = "searchUserToolStripMenuItem";
            resources.ApplyResources(searchUserToolStripMenuItem, "searchUserToolStripMenuItem");
            searchUserToolStripMenuItem.Click += searchToolStripMenuItem1_Click;
            // 
            // addUserToolStripMenuItem
            // 
            addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            resources.ApplyResources(addUserToolStripMenuItem, "addUserToolStripMenuItem");
            addUserToolStripMenuItem.Click += addUserToolStripMenuItem_Click;
            // 
            // editUserToolStripMenuItem
            // 
            editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            resources.ApplyResources(editUserToolStripMenuItem, "editUserToolStripMenuItem");
            editUserToolStripMenuItem.Click += editUserToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            resources.ApplyResources(deleteUserToolStripMenuItem, "deleteUserToolStripMenuItem");
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // citiesToolStripMenuItem1
            // 
            citiesToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { searchCitiesToolStripMenuItem, addCityToolStripMenuItem, editCityToolStripMenuItem, deleteCityToolStripMenuItem });
            citiesToolStripMenuItem1.Name = "citiesToolStripMenuItem1";
            resources.ApplyResources(citiesToolStripMenuItem1, "citiesToolStripMenuItem1");
            // 
            // searchCitiesToolStripMenuItem
            // 
            searchCitiesToolStripMenuItem.Name = "searchCitiesToolStripMenuItem";
            resources.ApplyResources(searchCitiesToolStripMenuItem, "searchCitiesToolStripMenuItem");
            searchCitiesToolStripMenuItem.Click += searchCitiesToolStripMenuItem_Click_1;
            // 
            // addCityToolStripMenuItem
            // 
            addCityToolStripMenuItem.Name = "addCityToolStripMenuItem";
            resources.ApplyResources(addCityToolStripMenuItem, "addCityToolStripMenuItem");
            addCityToolStripMenuItem.Click += addCityToolStripMenuItem_Click;
            // 
            // editCityToolStripMenuItem
            // 
            editCityToolStripMenuItem.Name = "editCityToolStripMenuItem";
            resources.ApplyResources(editCityToolStripMenuItem, "editCityToolStripMenuItem");
            editCityToolStripMenuItem.Click += editCityToolStripMenuItem_Click;
            // 
            // deleteCityToolStripMenuItem
            // 
            deleteCityToolStripMenuItem.Name = "deleteCityToolStripMenuItem";
            resources.ApplyResources(deleteCityToolStripMenuItem, "deleteCityToolStripMenuItem");
            deleteCityToolStripMenuItem.Click += deleteCityToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel });
            resources.ApplyResources(statusStrip1, "statusStrip1");
            statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            resources.ApplyResources(toolStripStatusLabel, "toolStripStatusLabel");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripMenuItem toursToolStripMenuItem;
        private ToolStripMenuItem searchTourToolStripMenuItem;
        private ToolStripMenuItem addTourStripMenuItem;
        private ToolStripMenuItem editTourToolStripMenuItem;
        private ToolStripMenuItem deleteTourToolStripMenuItem;
        private ToolStripMenuItem usersToolStripMenuItem;
        private ToolStripMenuItem searchUserToolStripMenuItem;
        private ToolStripMenuItem addUserToolStripMenuItem;
        private ToolStripMenuItem editUserToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
        private ToolStripMenuItem citiesToolStripMenuItem1;
        private ToolStripMenuItem searchCitiesToolStripMenuItem;
        private ToolStripMenuItem addCityToolStripMenuItem;
        private ToolStripMenuItem editCityToolStripMenuItem;
        private ToolStripMenuItem deleteCityToolStripMenuItem;
    }
}