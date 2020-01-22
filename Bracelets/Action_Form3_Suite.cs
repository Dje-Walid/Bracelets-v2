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
    public partial class Action_Form3_Suite : Form
    {
        public Action_Form3_Suite()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

            Action_Form3_Suite Action_Form3bSuite = new Action_Form3_Suite();
            Action_Form3bSuite.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resulta;
            resulta = MessageBox.Show("Êtes-vous sûr de vouloir annuler ", "AVERTISSEMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resulta == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();

            }
            else
            {

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
