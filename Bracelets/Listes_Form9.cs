﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using IniParser;
using IniParser.Model;

namespace Bracelet
{
    public partial class Listes_Form9 : Form
    {
        public Listes_Form9()
        {
            InitializeComponent();
        }

        private void environnementCourantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Saisie_Form1 saisie_Form1 = new Saisie_Form1();
            saisie_Form1.Show();
        }
        #region "Menu"
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
        #endregion

        private void Listes_Form9_Load(object sender, EventArgs e)
        {

            cbxLibRefus.Enabled = false;
            txbxTxtLettre.Enabled = false;
            chboxDroitRecours.Enabled = false;
            cbxLibRefus.BackColor = System.Drawing.SystemColors.Window;
            txbxTxtLettre.BackColor = System.Drawing.SystemColors.Window;
            cbxLibRefus.BackColor = System.Drawing.SystemColors.Window;
            
           
            


            Program.outils.getConnection().Open();
            string requete = "Select [CdRefus] from tlRefus;";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxCdeRefus.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();



           
        }

        private void cbxLibRefus_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void txbxTxtLettre_TextChanged(object sender, EventArgs e)
        {

        }

        private void chboxDroitRecours_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxCdeRefus_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLibRefus.Items.Clear();
            Program.outils.getConnection().Open();
            string requete1 = "Select [LibRefus] from tlRefus where [CdRefus] =" + Convert.ToString(cbxCdeRefus.Text) + ";";
            OleDbCommand cmd1 = new OleDbCommand(requete1, Program.outils.getConnection());
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                cbxLibRefus.Text = dr1[0].ToString();
                cbxLibRefus.Items.Add(dr1[0].ToString());
            }
            Program.outils.getConnection().Close();

            txbxTxtLettre.Clear();
            Program.outils.getConnection().Open();
            string requete2 = "Select [TexteLettre] from tlRefus where [CdRefus] =" + Convert.ToString(cbxCdeRefus.Text) + ";";
            OleDbCommand cmd2 = new OleDbCommand(requete2, Program.outils.getConnection());
            OleDbDataReader dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                txbxTxtLettre.Text = dr2[0].ToString();
            }
            Program.outils.getConnection().Close();

            chboxDroitRecours.Checked = false;
            Program.outils.getConnection().Open();
            string requete3 = "Select [AvecDroitRecours] from tlRefus where [CdRefus] =" + Convert.ToString(cbxCdeRefus.Text) + ";";
            OleDbCommand cmd3 = new OleDbCommand(requete3, Program.outils.getConnection());
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            while (dr3.Read())
            {
                chboxDroitRecours.Checked = Convert.ToBoolean(dr3[0]);
            }
            Program.outils.getConnection().Close();
        }

        private void btnModif_CheckedChanged(object sender, EventArgs e)
        {
            if (btnModif.Checked == true)
            {
                btnModif.Text = "Modifier";
                cbxLibRefus.Enabled = true;
                txbxTxtLettre.Enabled = true;
                chboxDroitRecours.Enabled = true; 

            }

            else
            {
                cbxLibRefus.Enabled = false;
                txbxTxtLettre.Enabled = false;
                chboxDroitRecours.Enabled = false;


                /* Program.outils.getConnection().Open();

                string requete1 = " update [tlRefus] set [LibRefus] = \""+cbxLibRefus.Text+"\" where [CdRefus] = \""+cbxCdeRefus.Text+"\";" ;
                string requete2 = " update [tlRefus] set [TexteLettre] = \"" + txbxTxtLettre.Text + "\"where [CdRefus] = \"" + cbxCdeRefus.Text + "\";";
                string requete3 = " update [tlRefus] set [AvecDroitRecours] = \"" + Convert.ToBoolean(chboxDroitRecours) + "\"where [CdRefus] = \"" + cbxCdeRefus.Text + "\";";
                

                OleDbCommand cmd1 = new OleDbCommand(requete1, Program.outils.getConnection());
                OleDbDataReader dr1 = cmd1.ExecuteReader();

                OleDbCommand cmd2 = new OleDbCommand(requete2, Program.outils.getConnection());
                OleDbDataReader dr2 = cmd2.ExecuteReader();

                OleDbCommand cmd3 = new OleDbCommand(requete3, Program.outils.getConnection());
                OleDbDataReader dr3 = cmd3.ExecuteReader();

                while (dr1.Read()&&dr2.Read()&&dr3.Read())
                 {
                     
                 }

                 Program.outils.getConnection().Close(); */
            }

        }

        private void Listes_Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
