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
    public partial class FormDetailBuku : Form
    {
        public FormDetailBuku()
        {
            InitializeComponent();
        }

        private void FormDetailBuku_Load(object sender, EventArgs e)
        {
            pictureBox2.Load("https://embassybooks.in/image/catalog/Child/9781408855676.jpg");
        }
    }
}
