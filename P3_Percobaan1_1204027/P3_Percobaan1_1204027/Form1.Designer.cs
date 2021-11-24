namespace P3_Percobaan1_1204027
{
    partial class Form1
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
            this.OutPutLabel = new System.Windows.Forms.Label();
            this.HelloButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OutPutLabel
            // 
            this.OutPutLabel.AutoSize = true;
            this.OutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OutPutLabel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutPutLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.OutPutLabel.Location = new System.Drawing.Point(14, 30);
            this.OutPutLabel.Name = "OutPutLabel";
            this.OutPutLabel.Size = new System.Drawing.Size(2, 28);
            this.OutPutLabel.TabIndex = 0;
            this.OutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HelloButton
            // 
            this.HelloButton.Location = new System.Drawing.Point(26, 114);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(111, 30);
            this.HelloButton.TabIndex = 1;
            this.HelloButton.Text = "&Say Hello";
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(193, 114);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(113, 30);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "E&xitt";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(348, 166);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.HelloButton);
            this.Controls.Add(this.OutPutLabel);
            this.Name = "Form1";
            this.Text = "Form Hello";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OutPutLabel;
        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

