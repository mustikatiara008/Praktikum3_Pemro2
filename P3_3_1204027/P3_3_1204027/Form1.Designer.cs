namespace P3_3_1204027
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Label = new System.Windows.Forms.Label();
            this.rbMonitor = new System.Windows.Forms.RadioButton();
            this.rbKeyboard = new System.Windows.Forms.RadioButton();
            this.rbMouse = new System.Windows.Forms.RadioButton();
            this.rbPrinter = new System.Windows.Forms.RadioButton();
            this.rbScanner = new System.Windows.Forms.RadioButton();
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.tsGambar = new System.Windows.Forms.ToolStrip();
            this.tsbMouse = new System.Windows.Forms.ToolStripButton();
            this.tsbMonitor = new System.Windows.Forms.ToolStripButton();
            this.tsbPrinter = new System.Windows.Forms.ToolStripButton();
            this.tsbKeyboard = new System.Windows.Forms.ToolStripButton();
            this.tsbScanner = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslKetGambar = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBox.SuspendLayout();
            this.tsGambar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Label.Location = new System.Drawing.Point(24, 49);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(526, 19);
            this.Label.TabIndex = 0;
            this.Label.Text = "Pilih salah satu item berikut dan klik pada gambar yang sesuai!";
            // 
            // rbMonitor
            // 
            this.rbMonitor.AutoSize = true;
            this.rbMonitor.Location = new System.Drawing.Point(64, 27);
            this.rbMonitor.Name = "rbMonitor";
            this.rbMonitor.Size = new System.Drawing.Size(94, 26);
            this.rbMonitor.TabIndex = 1;
            this.rbMonitor.TabStop = true;
            this.rbMonitor.Text = "Monitor";
            this.rbMonitor.UseVisualStyleBackColor = true;
            // 
            // rbKeyboard
            // 
            this.rbKeyboard.AutoSize = true;
            this.rbKeyboard.Location = new System.Drawing.Point(64, 68);
            this.rbKeyboard.Name = "rbKeyboard";
            this.rbKeyboard.Size = new System.Drawing.Size(112, 26);
            this.rbKeyboard.TabIndex = 2;
            this.rbKeyboard.TabStop = true;
            this.rbKeyboard.Text = "Keyboard";
            this.rbKeyboard.UseVisualStyleBackColor = true;
            // 
            // rbMouse
            // 
            this.rbMouse.AutoSize = true;
            this.rbMouse.Location = new System.Drawing.Point(64, 109);
            this.rbMouse.Name = "rbMouse";
            this.rbMouse.Size = new System.Drawing.Size(88, 26);
            this.rbMouse.TabIndex = 3;
            this.rbMouse.TabStop = true;
            this.rbMouse.Text = "Mouse";
            this.rbMouse.UseVisualStyleBackColor = true;
            // 
            // rbPrinter
            // 
            this.rbPrinter.AutoSize = true;
            this.rbPrinter.Location = new System.Drawing.Point(64, 150);
            this.rbPrinter.Name = "rbPrinter";
            this.rbPrinter.Size = new System.Drawing.Size(88, 26);
            this.rbPrinter.TabIndex = 4;
            this.rbPrinter.TabStop = true;
            this.rbPrinter.Text = "Printer";
            this.rbPrinter.UseVisualStyleBackColor = true;
            // 
            // rbScanner
            // 
            this.rbScanner.AutoSize = true;
            this.rbScanner.Location = new System.Drawing.Point(64, 191);
            this.rbScanner.Name = "rbScanner";
            this.rbScanner.Size = new System.Drawing.Size(102, 26);
            this.rbScanner.TabIndex = 5;
            this.rbScanner.TabStop = true;
            this.rbScanner.Text = "Scanner";
            this.rbScanner.UseVisualStyleBackColor = true;
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.rbMonitor);
            this.GroupBox.Controls.Add(this.rbScanner);
            this.GroupBox.Controls.Add(this.rbKeyboard);
            this.GroupBox.Controls.Add(this.rbPrinter);
            this.GroupBox.Controls.Add(this.rbMouse);
            this.GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox.Location = new System.Drawing.Point(45, 80);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(207, 248);
            this.GroupBox.TabIndex = 6;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "Nama Gambar";
            // 
            // tsGambar
            // 
            this.tsGambar.AutoSize = false;
            this.tsGambar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsGambar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGambar.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.tsGambar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMouse,
            this.tsbMonitor,
            this.tsbPrinter,
            this.tsbKeyboard,
            this.tsbScanner});
            this.tsGambar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.tsGambar.Location = new System.Drawing.Point(299, 80);
            this.tsGambar.Name = "tsGambar";
            this.tsGambar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsGambar.Size = new System.Drawing.Size(215, 266);
            this.tsGambar.TabIndex = 7;
            this.tsGambar.Text = "toolStrip1";
            // 
            // tsbMouse
            // 
            this.tsbMouse.AutoSize = false;
            this.tsbMouse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMouse.Image = ((System.Drawing.Image)(resources.GetObject("tsbMouse.Image")));
            this.tsbMouse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMouse.Name = "tsbMouse";
            this.tsbMouse.Size = new System.Drawing.Size(213, 44);
            this.tsbMouse.Tag = "Mouse";
            this.tsbMouse.Text = "Mouse";
            this.tsbMouse.Click += new System.EventHandler(this.tsbMouse_Click);
            // 
            // tsbMonitor
            // 
            this.tsbMonitor.AutoSize = false;
            this.tsbMonitor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMonitor.Image = ((System.Drawing.Image)(resources.GetObject("tsbMonitor.Image")));
            this.tsbMonitor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMonitor.Name = "tsbMonitor";
            this.tsbMonitor.Size = new System.Drawing.Size(213, 44);
            this.tsbMonitor.Tag = "Monitor";
            this.tsbMonitor.Text = "Monitor";
            this.tsbMonitor.Click += new System.EventHandler(this.tsbMonitor_Click);
            // 
            // tsbPrinter
            // 
            this.tsbPrinter.AutoSize = false;
            this.tsbPrinter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrinter.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrinter.Image")));
            this.tsbPrinter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrinter.Name = "tsbPrinter";
            this.tsbPrinter.Size = new System.Drawing.Size(213, 44);
            this.tsbPrinter.Tag = "Printer";
            this.tsbPrinter.Text = "Printer";
            this.tsbPrinter.Click += new System.EventHandler(this.tsbPrinter_Click);
            // 
            // tsbKeyboard
            // 
            this.tsbKeyboard.AutoSize = false;
            this.tsbKeyboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbKeyboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbKeyboard.Image")));
            this.tsbKeyboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKeyboard.Name = "tsbKeyboard";
            this.tsbKeyboard.Size = new System.Drawing.Size(213, 44);
            this.tsbKeyboard.Tag = "Keyboard";
            this.tsbKeyboard.Text = "Keyboard";
            this.tsbKeyboard.Click += new System.EventHandler(this.tsbKeyboard_Click);
            // 
            // tsbScanner
            // 
            this.tsbScanner.AutoSize = false;
            this.tsbScanner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbScanner.Image = ((System.Drawing.Image)(resources.GetObject("tsbScanner.Image")));
            this.tsbScanner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbScanner.Name = "tsbScanner";
            this.tsbScanner.Size = new System.Drawing.Size(213, 44);
            this.tsbScanner.Tag = "Scanner";
            this.tsbScanner.Text = "Scanner";
            this.tsbScanner.Click += new System.EventHandler(this.tsbScanner_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslKetGambar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslKetGambar
            // 
            this.tslKetGambar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslKetGambar.ForeColor = System.Drawing.Color.Red;
            this.tslKetGambar.Name = "tslKetGambar";
            this.tslKetGambar.Size = new System.Drawing.Size(0, 17);
            this.tslKetGambar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 428);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsGambar);
            this.Controls.Add(this.GroupBox);
            this.Controls.Add(this.Label);
            this.Name = "Form";
            this.Text = "Percobaan1_1204027";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.tsGambar.ResumeLayout(false);
            this.tsGambar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RadioButton rbMonitor;
        private System.Windows.Forms.RadioButton rbKeyboard;
        private System.Windows.Forms.RadioButton rbMouse;
        private System.Windows.Forms.RadioButton rbPrinter;
        private System.Windows.Forms.RadioButton rbScanner;
        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.ToolStrip tsGambar;
        private System.Windows.Forms.ToolStripButton tsbMouse;
        private System.Windows.Forms.ToolStripButton tsbMonitor;
        private System.Windows.Forms.ToolStripButton tsbPrinter;
        private System.Windows.Forms.ToolStripButton tsbKeyboard;
        private System.Windows.Forms.ToolStripButton tsbScanner;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslKetGambar;
    }
}

