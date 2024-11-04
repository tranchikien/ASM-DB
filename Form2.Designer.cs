namespace ASM1__DB
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesAndInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnfStaticsticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productManagementToolStripMenuItem,
            this.personnelManagementToolStripMenuItem,
            this.customerManagementToolStripMenuItem,
            this.salesAndInventoryToolStripMenuItem,
            this.reportAnfStaticsticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(858, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productManagementToolStripMenuItem
            // 
            this.productManagementToolStripMenuItem.Name = "productManagementToolStripMenuItem";
            this.productManagementToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.productManagementToolStripMenuItem.Text = "Product Management";
            this.productManagementToolStripMenuItem.Click += new System.EventHandler(this.productManagementToolStripMenuItem_Click);
            // 
            // personnelManagementToolStripMenuItem
            // 
            this.personnelManagementToolStripMenuItem.Name = "personnelManagementToolStripMenuItem";
            this.personnelManagementToolStripMenuItem.Size = new System.Drawing.Size(181, 24);
            this.personnelManagementToolStripMenuItem.Text = "Employee Management";
            this.personnelManagementToolStripMenuItem.Click += new System.EventHandler(this.personnelManagementToolStripMenuItem_Click);
            // 
            // customerManagementToolStripMenuItem
            // 
            this.customerManagementToolStripMenuItem.Name = "customerManagementToolStripMenuItem";
            this.customerManagementToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.customerManagementToolStripMenuItem.Text = "Customer Management";
            this.customerManagementToolStripMenuItem.Click += new System.EventHandler(this.customerManagementToolStripMenuItem_Click);
            // 
            // salesAndInventoryToolStripMenuItem
            // 
            this.salesAndInventoryToolStripMenuItem.Name = "salesAndInventoryToolStripMenuItem";
            this.salesAndInventoryToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.salesAndInventoryToolStripMenuItem.Text = "Sales and Inventory";
            this.salesAndInventoryToolStripMenuItem.Click += new System.EventHandler(this.ssalesAndInventoryToolStripMenuItem_Click);
            // 
            // reportAnfStaticsticsToolStripMenuItem
            // 
            this.reportAnfStaticsticsToolStripMenuItem.Name = "reportAnfStaticsticsToolStripMenuItem";
            this.reportAnfStaticsticsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.reportAnfStaticsticsToolStripMenuItem.Text = "Report and Statistics";
            this.reportAnfStaticsticsToolStripMenuItem.Click += new System.EventHandler(this.reportAnfStaticsticsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(858, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(87, 20);
            this.toolStripStatusLabel1.Text = "Information";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesAndInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnfStaticsticsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}