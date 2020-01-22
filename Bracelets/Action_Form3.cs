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
    public partial class Action_Form3 : Form
    {
        public Action_Form3()
        {
            InitializeComponent();
        }

        private void btnSelecMass_Click(object sender, EventArgs e)
        {
            Action_Form3_Suite action_Form3_SuiteA = new Action_Form3_Suite();
            action_Form3_SuiteA.Show();
        }

        private void btnAnnule_Click(object sender, EventArgs e)
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
    }
}
