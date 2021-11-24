namespace P3_2_1204027
{
    partial class ChilForm
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
            this.OutputLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.OutputGroupBox = new System.Windows.Forms.GroupBox();
            this.TimeOption = new System.Windows.Forms.RadioButton();
            this.DateOption = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.OutputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutputLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.OutputLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutputLabel.Location = new System.Drawing.Point(0, 0);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(2, 28);
            this.OutputLabel.TabIndex = 0;
            this.OutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(143, 62);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(76, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(61, 62);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(75, 23);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "&Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // OutputGroupBox
            // 
            this.OutputGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputGroupBox.Controls.Add(this.TimeOption);
            this.OutputGroupBox.Controls.Add(this.DateOption);
            this.OutputGroupBox.Location = new System.Drawing.Point(51, 171);
            this.OutputGroupBox.Name = "OutputGroupBox";
            this.OutputGroupBox.Size = new System.Drawing.Size(222, 133);
            this.OutputGroupBox.TabIndex = 2;
            this.OutputGroupBox.TabStop = false;
            this.OutputGroupBox.Text = "Choose Output:";
            // 
            // TimeOption
            // 
            this.TimeOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TimeOption.AutoSize = true;
            this.TimeOption.Location = new System.Drawing.Point(16, 60);
            this.TimeOption.Name = "TimeOption";
            this.TimeOption.Size = new System.Drawing.Size(180, 24);
            this.TimeOption.TabIndex = 0;
            this.TimeOption.TabStop = true;
            this.TimeOption.Text = "Display Current &Time";
            this.TimeOption.UseVisualStyleBackColor = true;
            this.TimeOption.Click += new System.EventHandler(this.TimeOption_Click);
            // 
            // DateOption
            // 
            this.DateOption.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateOption.AutoSize = true;
            this.DateOption.Location = new System.Drawing.Point(16, 30);
            this.DateOption.Name = "DateOption";
            this.DateOption.Size = new System.Drawing.Size(181, 24);
            this.DateOption.TabIndex = 1;
            this.DateOption.TabStop = true;
            this.DateOption.Text = "Display Current D&ate";
            this.DateOption.UseVisualStyleBackColor = true;
            this.DateOption.Click += new System.EventHandler(this.DateOption_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 334);
            this.Controls.Add(this.OutputGroupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.OutputLabel);
            this.Name = "ChilForm";
            this.Text = "Child Form";
            this.OutputGroupBox.ResumeLayout(false);
            this.OutputGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.GroupBox OutputGroupBox;
        private System.Windows.Forms.RadioButton TimeOption;
        private System.Windows.Forms.RadioButton DateOption;
        private System.Windows.Forms.Button button1;
    }
}