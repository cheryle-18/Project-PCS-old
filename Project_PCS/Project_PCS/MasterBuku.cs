using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace Project_PCS
{
    public partial class MasterBuku : Form
    {
        public MasterBuku()
        {
            InitializeComponent();
        }

        private void MasterBuku_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            this.Close();
        }

        private void btnTransaksi_MouseHover(object sender, EventArgs e)
        {
            btnTransaksi.BackColor = Color.White;
            btnTransaksi.ForeColor = Color.Navy;
        }

        private void btnTransaksi_MouseLeave(object sender, EventArgs e)
        {
            btnTransaksi.BackColor = Color.Navy;
            btnTransaksi.ForeColor = Color.White;
        }

        private void btnPreOrder_MouseHover(object sender, EventArgs e)
        {
            btnPreOrder.BackColor = Color.White;
            btnPreOrder.ForeColor = Color.Navy;
        }

        private void btnPreOrder_MouseLeave(object sender, EventArgs e)
        {
            btnPreOrder.BackColor = Color.Navy;
            btnPreOrder.ForeColor = Color.White;
        }

        private void btnMember_MouseLeave(object sender, EventArgs e)
        {
            btnMember.BackColor = Color.White;
            btnMember.ForeColor = Color.Navy;
        }

        private void btnMember_MouseHover(object sender, EventArgs e)
        {
            btnMember.BackColor = Color.Navy;
            btnMember.ForeColor = Color.White;
        }
    }
}
