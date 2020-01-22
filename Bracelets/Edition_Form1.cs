using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bracelet
{
    public partial class Edition_Form1 : Form
    {
        public Edition_Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            this.Close();

            Edition_Form1 edition_Form1A = new Edition_Form1();
            edition_Form1A.Show();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
