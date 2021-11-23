using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_4_1204011
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_Click(object sender, EventArgs e)
        {
            string kelas = "";
            string jadwal = "";

            if (jadwal1.Checked)
            {
                jadwal = "Senin & Rabu, 14.00-16.00";
            }
            else if (jadwal2.Checked)
            {
                jadwal = "Selasa & Kamis, 14.00-16.00";
            }
            else if (jadwal3.Checked)
            {
                jadwal = "Sabtu & Minggu, 9.00-11.00";
            }
            else if (jadwal4.Checked)
            {
                jadwal = "Minggu, 13.00-17.00";
            }

            if (biola.Checked)
            {
                kelas += "Biola ";
            }
            if (drum.Checked)
            {
                kelas += "Drum ";
            }
            if (gitar.Checked)
            {
                kelas += "Gitar ";
            }
            if (kom.Checked)
            {
                kelas += "Komposer ";
            }
            if (sax.Checked)
            {
                kelas += "Saxophone ";
            }
            if (vokal.Checked)
            {
                kelas += "Vokal ";
            }
            if (kon.Checked)
            {
                kelas += "Konduktor ";
            }
            if (piano.Checked)
            {
                kelas += "Piano ";
            }
            if(kelas == "")
            {
                MessageBox.Show("Harus Memilih salah satu dari pilihan kelas ", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Nama : " + namabox.Text +
                "\nJenis Kelamin : " + jk.Text +
                "\nTanggal Lahir : " + dateTimePicker1.Text +
                "\nPilihan Kelas : " + kelas +
                "\nPilihan Jadwal : " + jadwal,
                "Informasi Pendaftaran",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
