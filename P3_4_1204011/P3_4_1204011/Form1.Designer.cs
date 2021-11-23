namespace P3_4_1204011

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
            this.namabox = new System.Windows.Forms.TextBox();
            this.jk = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.kom = new System.Windows.Forms.CheckBox();
            this.biola = new System.Windows.Forms.CheckBox();
            this.vokal = new System.Windows.Forms.CheckBox();
            this.gitar = new System.Windows.Forms.CheckBox();
            this.drum = new System.Windows.Forms.CheckBox();
            this.sax = new System.Windows.Forms.CheckBox();
            this.piano = new System.Windows.Forms.CheckBox();
            this.kon = new System.Windows.Forms.CheckBox();
            this.jadwal = new System.Windows.Forms.GroupBox();
            this.jadwal4 = new System.Windows.Forms.RadioButton();
            this.jadwal3 = new System.Windows.Forms.RadioButton();
            this.jadwal2 = new System.Windows.Forms.RadioButton();
            this.jadwal1 = new System.Windows.Forms.RadioButton();
            this.show = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.kelas.SuspendLayout();
            this.jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form Pendaftaran";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 152);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tanggal Lahir";
            // 
            // namabox
            // 
            this.namabox.Location = new System.Drawing.Point(372, 108);
            this.namabox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namabox.Name = "namabox";
            this.namabox.Size = new System.Drawing.Size(298, 26);
            this.namabox.TabIndex = 4;
            // 
            // jk
            // 
            this.jk.FormattingEnabled = true;
            this.jk.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.jk.Location = new System.Drawing.Point(372, 152);
            this.jk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jk.Name = "jk";
            this.jk.Size = new System.Drawing.Size(298, 28);
            this.jk.TabIndex = 5;
            this.jk.Text = "-pilih jenis kelamin-";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 197);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // kelas
            // 
            this.kelas.Controls.Add(this.kom);
            this.kelas.Controls.Add(this.biola);
            this.kelas.Controls.Add(this.vokal);
            this.kelas.Controls.Add(this.gitar);
            this.kelas.Controls.Add(this.drum);
            this.kelas.Controls.Add(this.sax);
            this.kelas.Controls.Add(this.piano);
            this.kelas.Controls.Add(this.kon);
            this.kelas.Location = new System.Drawing.Point(38, 315);
            this.kelas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kelas.Name = "kelas";
            this.kelas.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kelas.Size = new System.Drawing.Size(300, 262);
            this.kelas.TabIndex = 7;
            this.kelas.TabStop = false;
            this.kelas.Text = "Pilihan Kelas";
            // 
            // kom
            // 
            this.kom.AutoSize = true;
            this.kom.Location = new System.Drawing.Point(171, 171);
            this.kom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kom.Name = "kom";
            this.kom.Size = new System.Drawing.Size(107, 24);
            this.kom.TabIndex = 15;
            this.kom.Text = "Komposer";
            this.kom.UseVisualStyleBackColor = true;
            // 
            // biola
            // 
            this.biola.AutoSize = true;
            this.biola.Location = new System.Drawing.Point(10, 65);
            this.biola.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.biola.Name = "biola";
            this.biola.Size = new System.Drawing.Size(70, 24);
            this.biola.TabIndex = 8;
            this.biola.Text = "Biola";
            this.biola.UseVisualStyleBackColor = true;
            // 
            // vokal
            // 
            this.vokal.AutoSize = true;
            this.vokal.Location = new System.Drawing.Point(171, 135);
            this.vokal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.vokal.Name = "vokal";
            this.vokal.Size = new System.Drawing.Size(75, 24);
            this.vokal.TabIndex = 14;
            this.vokal.Text = "Vokal";
            this.vokal.UseVisualStyleBackColor = true;
            // 
            // gitar
            // 
            this.gitar.AutoSize = true;
            this.gitar.Location = new System.Drawing.Point(9, 100);
            this.gitar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gitar.Name = "gitar";
            this.gitar.Size = new System.Drawing.Size(70, 24);
            this.gitar.TabIndex = 9;
            this.gitar.Text = "Gitar";
            this.gitar.UseVisualStyleBackColor = true;
            // 
            // drum
            // 
            this.drum.AutoSize = true;
            this.drum.Location = new System.Drawing.Point(171, 100);
            this.drum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drum.Name = "drum";
            this.drum.Size = new System.Drawing.Size(74, 24);
            this.drum.TabIndex = 13;
            this.drum.Text = "Drum";
            this.drum.UseVisualStyleBackColor = true;
            // 
            // sax
            // 
            this.sax.AutoSize = true;
            this.sax.Location = new System.Drawing.Point(10, 135);
            this.sax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sax.Name = "sax";
            this.sax.Size = new System.Drawing.Size(116, 24);
            this.sax.TabIndex = 10;
            this.sax.Text = "Saxophone";
            this.sax.UseVisualStyleBackColor = true;
            // 
            // piano
            // 
            this.piano.AutoSize = true;
            this.piano.Location = new System.Drawing.Point(171, 65);
            this.piano.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.piano.Name = "piano";
            this.piano.Size = new System.Drawing.Size(75, 24);
            this.piano.TabIndex = 12;
            this.piano.Text = "Piano";
            this.piano.UseVisualStyleBackColor = true;
            // 
            // kon
            // 
            this.kon.AutoSize = true;
            this.kon.Location = new System.Drawing.Point(10, 171);
            this.kon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.kon.Name = "kon";
            this.kon.Size = new System.Drawing.Size(108, 24);
            this.kon.TabIndex = 11;
            this.kon.Text = "Konduktor";
            this.kon.UseVisualStyleBackColor = true;
            // 
            // jadwal
            // 
            this.jadwal.Controls.Add(this.jadwal4);
            this.jadwal.Controls.Add(this.jadwal3);
            this.jadwal.Controls.Add(this.jadwal2);
            this.jadwal.Controls.Add(this.jadwal1);
            this.jadwal.Location = new System.Drawing.Point(408, 315);
            this.jadwal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal.Name = "jadwal";
            this.jadwal.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal.Size = new System.Drawing.Size(326, 262);
            this.jadwal.TabIndex = 0;
            this.jadwal.TabStop = false;
            this.jadwal.Text = "Pilihan Jadwal";
            // 
            // jadwal4
            // 
            this.jadwal4.AutoSize = true;
            this.jadwal4.Location = new System.Drawing.Point(44, 171);
            this.jadwal4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal4.Name = "jadwal4";
            this.jadwal4.Size = new System.Drawing.Size(179, 24);
            this.jadwal4.TabIndex = 3;
            this.jadwal4.TabStop = true;
            this.jadwal4.Text = "Minggu, 13.00-17.00";
            this.jadwal4.UseVisualStyleBackColor = true;
            // 
            // jadwal3
            // 
            this.jadwal3.AutoSize = true;
            this.jadwal3.Location = new System.Drawing.Point(44, 135);
            this.jadwal3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal3.Name = "jadwal3";
            this.jadwal3.Size = new System.Drawing.Size(241, 24);
            this.jadwal3.TabIndex = 2;
            this.jadwal3.TabStop = true;
            this.jadwal3.Text = "Sabtu && Minggu, 09.00-11.00";
            this.jadwal3.UseVisualStyleBackColor = true;
            // 
            // jadwal2
            // 
            this.jadwal2.AutoSize = true;
            this.jadwal2.Location = new System.Drawing.Point(44, 100);
            this.jadwal2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal2.Name = "jadwal2";
            this.jadwal2.Size = new System.Drawing.Size(238, 24);
            this.jadwal2.TabIndex = 1;
            this.jadwal2.TabStop = true;
            this.jadwal2.Text = "Selasa && Kamis, 14.00-16.00";
            this.jadwal2.UseVisualStyleBackColor = true;
            // 
            // jadwal1
            // 
            this.jadwal1.AutoSize = true;
            this.jadwal1.Location = new System.Drawing.Point(44, 65);
            this.jadwal1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jadwal1.Name = "jadwal1";
            this.jadwal1.Size = new System.Drawing.Size(226, 24);
            this.jadwal1.TabIndex = 0;
            this.jadwal1.TabStop = true;
            this.jadwal1.Text = "Senin && Rabu, 14.00-16.00";
            this.jadwal1.UseVisualStyleBackColor = true;
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(134, 631);
            this.show.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(112, 35);
            this.show.TabIndex = 4;
            this.show.Text = "Tampilkan";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(524, 631);
            this.finish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(112, 35);
            this.finish.TabIndex = 5;
            this.finish.Text = "Selesai";
            this.finish.UseVisualStyleBackColor = true;
            this.finish.Click += new System.EventHandler(this.finish_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(846, 709);
            this.Controls.Add(this.show);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.jadwal);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.jk);
            this.Controls.Add(this.namabox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ASTRA MUSIC SCHOOL";
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.jadwal.ResumeLayout(false);
            this.jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox namabox;
        private System.Windows.Forms.ComboBox jk;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.CheckBox biola;
        private System.Windows.Forms.CheckBox gitar;
        private System.Windows.Forms.CheckBox sax;
        private System.Windows.Forms.GroupBox jadwal;
        private System.Windows.Forms.CheckBox kon;
        private System.Windows.Forms.CheckBox piano;
        private System.Windows.Forms.CheckBox drum;
        private System.Windows.Forms.CheckBox vokal;
        private System.Windows.Forms.CheckBox kom;
        private System.Windows.Forms.RadioButton jadwal4;
        private System.Windows.Forms.RadioButton jadwal3;
        private System.Windows.Forms.RadioButton jadwal2;
        private System.Windows.Forms.RadioButton jadwal1;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Button finish;
    }
}

