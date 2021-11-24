namespace P3_Percobaan4_1204027
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nama = new System.Windows.Forms.TextBox();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbSaxophone = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(365, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "FORM PENDAFTARAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // Nama
            // 
            this.Nama.Location = new System.Drawing.Point(438, 128);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(221, 32);
            this.Nama.TabIndex = 4;
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(438, 209);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(237, 32);
            this.cbJK.TabIndex = 5;
            this.cbJK.Text = "-- pilih jenis kelamin --";
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(438, 293);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(286, 32);
            this.dtTglLahir.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbKomposer);
            this.groupBox1.Controls.Add(this.cbVokal);
            this.groupBox1.Controls.Add(this.cbDrum);
            this.groupBox1.Controls.Add(this.cbPiano);
            this.groupBox1.Controls.Add(this.cbKonduktor);
            this.groupBox1.Controls.Add(this.cbSaxophone);
            this.groupBox1.Controls.Add(this.cbGitar);
            this.groupBox1.Controls.Add(this.cbBiola);
            this.groupBox1.Location = new System.Drawing.Point(72, 346);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 281);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pilihan Kelas";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.rbJadwal4);
            this.groupBox2.Controls.Add(this.rbJadwal3);
            this.groupBox2.Controls.Add(this.rbJadwal2);
            this.groupBox2.Controls.Add(this.rbJadwal1);
            this.groupBox2.Location = new System.Drawing.Point(768, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 264);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pilihan Jadwal";
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Location = new System.Drawing.Point(69, 63);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(285, 28);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin && Rabu, 14.00 - 16.00";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(69, 106);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(303, 28);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa && Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(69, 163);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(306, 28);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu && Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(69, 215);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(230, 28);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(27, 49);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(80, 28);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(27, 106);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(79, 28);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbSaxophone
            // 
            this.cbSaxophone.AutoSize = true;
            this.cbSaxophone.Location = new System.Drawing.Point(27, 163);
            this.cbSaxophone.Name = "cbSaxophone";
            this.cbSaxophone.Size = new System.Drawing.Size(134, 28);
            this.cbSaxophone.TabIndex = 2;
            this.cbSaxophone.Text = "Saxophone";
            this.cbSaxophone.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(27, 228);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(127, 28);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(203, 63);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(85, 28);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(203, 116);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(85, 28);
            this.cbDrum.TabIndex = 5;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(203, 169);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(85, 28);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(203, 231);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(125, 28);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(438, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "&Tampilkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(590, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "&Selesai";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1248, 654);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Atra Music School";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbSaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

