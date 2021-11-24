namespace P3_2_1204027
{
    partial class ParentFrom
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
            this.MdiContainer = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileTMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MdiContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // MdiContainer
            // 
            this.MdiContainer.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MdiContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this.WindowMenuItem});
            this.MdiContainer.Location = new System.Drawing.Point(0, 0);
            this.MdiContainer.Name = "MdiContainer";
            this.MdiContainer.Size = new System.Drawing.Size(461, 33);
            this.MdiContainer.TabIndex = 0;
            this.MdiContainer.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.ExitMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(50, 29);
            this.FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.Size = new System.Drawing.Size(131, 30);
            this.NewMenuItem.Text = "&New";
            this.NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(131, 30);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // WindowMenuItem
            // 
            this.WindowMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeMenuItem,
            this.WindowTileTMenuItem});
            this.WindowMenuItem.Name = "WindowMenuItem";
            this.WindowMenuItem.Size = new System.Drawing.Size(90, 29);
            this.WindowMenuItem.Text = "&Window";
            // 
            // WindowCascadeMenuItem
            // 
            this.WindowCascadeMenuItem.Name = "WindowCascadeMenuItem";
            this.WindowCascadeMenuItem.Size = new System.Drawing.Size(210, 30);
            this.WindowCascadeMenuItem.Text = "&Cascade";
            this.WindowCascadeMenuItem.Click += new System.EventHandler(this.WindowCascadeMenuItem_Click);
            // 
            // WindowTileTMenuItem
            // 
            this.WindowTileTMenuItem.Name = "WindowTileTMenuItem";
            this.WindowTileTMenuItem.Size = new System.Drawing.Size(210, 30);
            this.WindowTileTMenuItem.Text = "&Tile";
            this.WindowTileTMenuItem.Click += new System.EventHandler(this.WindowTileTMenuItem_Click);
            // 
            // ParentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 303);
            this.Controls.Add(this.MdiContainer);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MdiContainer;
            this.Name = "ParentFrom";
            this.Text = "Parent From";
            this.MdiContainer.ResumeLayout(false);
            this.MdiContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MdiContainer;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WindowTileTMenuItem;
    }
}

