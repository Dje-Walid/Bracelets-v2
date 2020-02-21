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
    public partial class Action_Form1_suite : Form
    {
        public Action_Form1_suite()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void cbxMasIn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Action_Form1_suite_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'braceletBDDDataSet4.tlMassifs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tlMassifsTableAdapter.Fill(this.braceletBDDDataSet4.tlMassifs);

        }
    }
}
