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

        private void bt_Annuler_Click(object sender, EventArgs e)
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

        private void environnementCourantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saisie_Form1 saisie_Form1 = new Saisie_Form1();
            saisie_Form1.Show();
        }

        private void quitterBraceletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult resulta;
            resulta = MessageBox.Show("Êtes-vous sûr de vouloir quittez", "AVERTISSEMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
            this.Hide();
            Action_Form1 action_Form1 = new Action_Form1();
            action_Form1.Show();
        }

        private void documentsCommissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form2 edition_Form2 = new Edition_Form2();
            edition_Form2.Show();
        }

        private void listeDesAttributionsAccordéesSousRéserveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form3 listes_Form3 = new Listes_Form3();
            listes_Form3.Show();
        }

        private void codesEspècesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form6 listes_Form6 = new Listes_Form6();
            listes_Form6.Show();
        }

        private void attributionBraceletsAutomatiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form3 action_Form3A = new Action_Form3();
            action_Form3A.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void documentsSouscommissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form1 Edition_Form1a = new Edition_Form1();
            Edition_Form1a.Show();
        }

        private void editionsDDAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void arrêtésIndividuelsTirÀLapprocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F1 Edition_Form3_F1a = new Edition_Form3_F1();
            Edition_Form3_F1a.Show();
        }

        private void arrêtésRécapitulatifDeTirÀLapprocheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F2 Edition_Form3_F2a = new Edition_Form3_F2();
            Edition_Form3_F2a.Show();
        }

        private void arrêtésIndividuelsDattributionDeBraceletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F3 Edition_Form3_F3a = new Edition_Form3_F3();
            Edition_Form3_F3a.Show();
        }

        private void arrêtésIndividuelsDattributionDeBraceletsV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F4 Edition_Form3_F4a = new Edition_Form3_F4();
            Edition_Form3_F4a.Show();
        }

        private void arrêtésRécapitulatifDattributionDeBraceletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F5 Edition_Form3_F5a = new Edition_Form3_F5();
            Edition_Form3_F5a.Show();
        }

        private void réponseAuxDemandesDePlanDeChasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edition_Form3_F6 Edition_Form3_F6a = new Edition_Form3_F6();
            Edition_Form3_F6a.Show();
        }

        private void editionsFédérationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listingDétiquettesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_Form4_F1 Edition_Form4_F1a = new Edition_Form4_F1();
            Edition_Form4_F1a.Show();
        }

        private void statistiquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void statistiquesParZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_Form5_F1 Edition_Form5_F1a = new Edition_Form5_F1();
            Edition_Form5_F1a.Show();
        }

        private void statistiquesParCommunesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_Form5_F2 Edition_Form5_F2a = new Edition_Form5_F2();
            Edition_Form5_F2a.Show();
        }

        private void statistiquesRéalisésListésParCommunesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edition_Form5_F3 Edition_Form5_F3a = new Edition_Form5_F3();
            Edition_Form5_F3a.Show();
        }

        private void recapitulatifDesAttributionsParZoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form1 listes_Form1a = new Listes_Form1();
            listes_Form1a.Show();
        }

        private void lettreDeRelanceRéalisésNonRenseignésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form2 listes_Form2a = new Listes_Form2();
            listes_Form2a.Show();
        }

        private void codesZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form4 listes_Form4a = new Listes_Form4();
            listes_Form4a.Show();
        }

        private void codesTypesDePlanDeChasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form5 listes_Form5a = new Listes_Form5();
            listes_Form5a.Show();
        }

        private void codesSériesDeBraceletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form7 listes_Form7a = new Listes_Form7();
            listes_Form7a.Show();
        }

        private void codesGibiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form8 listes_Form8a = new Listes_Form8();
            listes_Form8a.Show();
        }

        private void codesRefusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form9 listes_Form9a = new Listes_Form9();
            listes_Form9a.Show();
        }

        private void codesCampagnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form10 listes_Form10a = new Listes_Form10();
            listes_Form10a.Show();
        }

        private void codesCommunesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listes_Form11 listes_Form11a = new Listes_Form11();
            listes_Form11a.Show();
        }

        private void editionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportationVersLaFédérationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportExport_Form1 importExport_Form1a = new ImportExport_Form1();
            importExport_Form1a.Show();
        }

       

        private void changerDeMotDePasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Securite_Form1 Securite_Form1a = new Securite_Form1();
            Securite_Form1a.Show();
        }

        private void manuelUtilisateurWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aide_Form1 Aide_Form1a = new Aide_Form1();
            Aide_Form1a.Show();

            //Lancement de l'extension Word
            Microsoft.Office.Interop.Word.Application msWord = new Microsoft.Office.Interop.Word.Application();
            msWord.Visible = false;
            object missing = System.Reflection.Missing.Value;

            //Lancement du fichier word
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "Manuel Utilisateur.doc";
            proc.Start();
            proc.Close();
        }

        private void aProposDeBraceletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Aide_Form2 Aide_Form2a = new Aide_Form2();
            Aide_Form2a.Show();
        }

        private void saisirConsulterLesPlanDeChasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saisie_Form2 Saisie_Form2 = new Saisie_Form2();
            Saisie_Form2.Show();
        }

        private void basculerFDCYEnONFEDDAFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form2 action_Form2 = new Action_Form2();
            action_Form2.Show();
        }

        private void modificationsDattributionManuellesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changerLeBénéficiaireDunBraceletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form4_F1 action_Form4_F1 = new Action_Form4_F1();
            action_Form4_F1.Show();
        }

        private void supprimerUnBraceletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form4_F2 action_Form4_F2 = new Action_Form4_F2();
            action_Form4_F2.Show();
        }

        private void paramétrageDesBraceletsPourLesCampagnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form5_F1 action_Form5_F1 = new Action_Form5_F1();
            action_Form5_F1.Show();
        }

        private void paramMinimaÀTuerParEspècesEtParZonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form5_F2 action_Form5_F2 = new Action_Form5_F2();
            action_Form5_F2.Show();
        }

        private void historiqueDesDatesDesActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form5_F3 action_Form5_F3 = new Action_Form5_F3();
            action_Form5_F3.Show();
        }

        private void historiqueDesModifsDeNumérosDePlansDeChasseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Action_Form5_F4 action_Form5_F4 = new Action_Form5_F4();
            action_Form5_F4.Show();
        }

        private void exportationExcelToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportExport_Form1 importExport_Form1a = new ImportExport_Form1();
            importExport_Form1a.Show();
        }

        private void Edition_Form1_Load(object sender, EventArgs e)
        {

        }

        private void Edition_Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
