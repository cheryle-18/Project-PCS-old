using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PCS
{
    public partial class MasterPegawaiAdmin : Form
    {
        public MasterPegawaiAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDetailPegawaiAdmin frm = new FormDetailPegawaiAdmin();
            frm.ShowDialog();
        }

        private void MasterPegawaiAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnPenerbit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterPenerbitAdmin frm = new MasterPenerbitAdmin();
            frm.ShowDialog();
        }

        private void btnBuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterBukuAdmin frm = new MasterBukuAdmin();
            frm.ShowDialog();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPegawaiBaruAdmin frm = new FormPegawaiBaruAdmin();
            frm.ShowDialog();
        }
    }
}
