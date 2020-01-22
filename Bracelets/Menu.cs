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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quitterBraceletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportationExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void environnementCourantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saisie_Form1 saisie_Form1 = new Saisie_Form1();
            saisie_Form1.Show();
        }

        private void quitterBraceletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resulta; 
            resulta =MessageBox.Show("Êtes-vous sûr de vouloir quittez", "AVERTISSEMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resulta == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {

            }

            
            
        }

        private void basculerProposésAccordésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_Form1 action_Form1 = new Action_Form1();
            action_Form1.Show();
        }

        private void documentsCommissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_Form2 edition_Form2 = new Edition_Form2();
            edition_Form2.Show();
        }

        private void listeDesAttributionsAccordéesSousRéserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes_Form3 listes_Form3 = new Listes_Form3();
            listes_Form3.Show();
        }

        private void codesEspècesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listes_Form6 listes_Form6 = new Listes_Form6();
            listes_Form6.Show();
        }

        private void attributionBraceletsAutomatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Action_Form3 action_Form3A = new Action_Form3();
            action_Form3A.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
