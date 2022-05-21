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
    public partial class FormDetailPenerbitAdmin : Form
    {
        public FormDetailPenerbitAdmin()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MasterPenerbitAdmin frm = new MasterPenerbitAdmin();
            frm.ShowDialog();
        }
    }
}
