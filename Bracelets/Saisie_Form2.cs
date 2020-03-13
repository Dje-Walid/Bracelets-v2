using System;
using System.Data.OleDb;
using System.Linq;
using System.Windows.Forms;
using ADOX;

namespace Bracelet
{
    public partial class Saisie_Form2 : Form
    {
        public Saisie_Form2()
        {
            InitializeComponent();

            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }
        }

        private void quitterBraceletToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Saisie_Form2_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tbGibiers'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbGibiersTableAdapter.Fill(this.braceletBDD.tbGibiers);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tbCampagnes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbCampagnesTableAdapter.Fill(this.braceletBDD.tbCampagnes);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tlCampagnes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tlCampagnesTableAdapter.Fill(this.braceletBDD.tlCampagnes);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tlMassifs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tlMassifsTableAdapter.Fill(this.braceletBDD.tlMassifs);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tlCommunes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tlCommunesTableAdapter.Fill(this.braceletBDD.tlCommunes);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tbCommunes'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbCommunesTableAdapter.Fill(this.braceletBDD.tbCommunes);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tbBenefs'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbBenefsTableAdapter.Fill(this.braceletBDD.tbBenefs);
            // TODO: cette ligne de code charge les données dans la table 'braceletBDD.tbPlans'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.tbPlansTableAdapter.Fill(this.braceletBDD.tbPlans);

            #region "Insertion des outils dans les Controls"
            /*//Insertion des outils dans les Controls
            this.Controls.Add(cbxNumPlan);
            this.Controls.Add(cbxNomBenef);
            this.Controls.Add(cbxSte);
            this.Controls.Add(txbxPlanChasse);
            this.Controls.Add(txbxCommuPrin);
            this.Controls.Add(txbxIDK);
            this.Controls.Add(cbxBenef);
            this.Controls.Add(txbxBenef);
            this.Controls.Add(cbxCivilite);
            this.Controls.Add(txbxNomInfoBenef);
            this.Controls.Add(txbxPrenom);
            this.Controls.Add(txbxSociete);
            this.Controls.Add(txbxRue);
            this.Controls.Add(txbxLieuDit);
            this.Controls.Add(txbxCP);
            this.Controls.Add(cbxVille);
            this.Controls.Add(txbxTelephone);
            this.Controls.Add(txbxFax);
            this.Controls.Add(txbxMail);
            this.Controls.Add(txbxPortable);
            this.Controls.Add(txbxNotes);
            this.Controls.Add(dtpDateModif);
            this.Controls.Add(dgvCommunes);
            this.Controls.Add(txbxNotesInternes);
            this.Controls.Add(dtpDateCreaPlan);
            this.Controls.Add(dtpDateModifPlan);
            this.Controls.Add(txbxDateSuppPlan);
            this.Controls.Add(txbxCampActu);
            this.Controls.Add(txbxBoisPrive);
            this.Controls.Add(txbxBoisSoumis);
            this.Controls.Add(txbxTTBois);
            this.Controls.Add(txbxPlaine);
            this.Controls.Add(txbxTTSurfChasse);
            this.Controls.Add(txbxSecChevreuil);
            this.Controls.Add(txbxSecSanglier);
            this.Controls.Add(txbxSecCerf);
            this.Controls.Add(cbxNomGroupement);
            this.Controls.Add(txbxObservations);
            this.Controls.Add(cbxRefus);
            this.Controls.Add(chbxPointNoir);
            this.Controls.Add(dgvEspeces);
            this.Controls.Add(dgvGibiers);
            this.Controls.Add(dgvBracletParGibier);
            this.Controls.Add(dtpLastAttribution);
            this.Controls.Add(dtpCrea);
            this.Controls.Add(dtpLastModif);
            this.Controls.Add(txbxNumLastAttribution);*/
            #endregion

            #region "Remplissage des outils au lancement de l'application" 
            //Remplissage cbxNumPlan
            Program.outils.getConnection().Open();
            string requete = "Select [NumPlan] from tbPlans group by [NumPlan];";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNumPlan.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            //Remplissage cbxNom
            Program.outils.getConnection().Open();
            requete = "Select [NomBenef] from tbBenefs group by [NomBenef];";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNomBenef.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            //Remplissage du cbxSte
            Program.outils.getConnection().Open();
            requete = " Select [NomSociete] from tbBenefs group by [NomSociete];";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbxSte.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            #endregion

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbNumPlan_Click(object sender, EventArgs e)
        {

        }

        private void dtpLastAttribution_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txbxPlanChasse_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbxSte_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        #region "Menu"
        private void exportationExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void paramétrageDesActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportExport_Form1 importExport_Form1a = new ImportExport_Form1();
            importExport_Form1a.Show();
        }

        private void imprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxCommuPrin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grbInfoBenef_Enter(object sender, EventArgs e)
        {

        }

        private void txbxTTBois_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxNumPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Remplissage lorsque NumPlan est selectionné"
            //Tri des NomBenef
            cbxNomBenef.Items.Clear();
            Program.outils.getConnection().Open();
            string requete = "Select [NomBenef] from tbBenefs where [CdBenef] in (Select [CdBenef] from tbPlans where [NumPlan] =\"" + Convert.ToString(cbxNumPlan.Text) + "\") group by [NomBenef];";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNomBenef.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            //Tri des sociétés
            cbxSte.Items.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [NomSociete] from tbBenefs where [CdBenef] in (Select [CdBenef] from tbPlans where [NumPlan] =\"" + Convert.ToString(cbxNumPlan.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxSte.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();


            #endregion
        }

        private void txbxSecChevreuil_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxNomBenef_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region "Remplissage lorsque le NomBenef est sélectionné"
            //Tri des NumPlan
            cbxNumPlan.Items.Clear();
            Program.outils.getConnection().Open();
            string requete = "Select [NumPlan] from tbPlans where [CdBenef] in (Select [CdBenef] from tbBenefs where [NomBenef] =\"" + Convert.ToString(cbxNomBenef.Text) + "\");";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNumPlan.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            //Tri des sociétés
            cbxSte.Items.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [NomSociete] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxNomBenef.Text) + "\";";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxSte.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();
            #endregion
        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            #region "Bouton pour effacer"
            //Remplissage cbxNumPlan
            cbxNumPlan.Items.Clear();
            Program.outils.getConnection().Open();
            string requete = "Select [NumPlan] from tbPlans group by [NumPlan];";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNumPlan.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();
            cbxNumPlan.Text = "";

            //Remplissage cbxNom
            cbxNomBenef.Items.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [NomBenef] from tbBenefs group by [NomBenef];";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxNomBenef.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();
            cbxNomBenef.Text = "";

            //Remplissage du cbxSte
            cbxSte.Items.Clear();
            Program.outils.getConnection().Open();
            requete = " Select [NomSociete] from tbBenefs group by [NomSociete];";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbxSte.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();
            cbxSte.Text = "";
            #endregion
        }

        private void btRecherche_Click(object sender, EventArgs e)
        {
            if (cbxNomBenef.Text == "" || cbxNumPlan.Text == "")
            {
                MessageBox.Show("Veuillez saisir le nom du bénéficiaire ainsi que le numéro du plan de chasse.", "Requête impossible par manque d'informations", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                #region "Reset des données pour reselectionner"
                //Remplissage cbxNumPlan
                cbxNumPlan.Items.Clear();
                Program.outils.getConnection().Open();
                string requete = "Select [NumPlan] from tbPlans group by [NumPlan];";
                OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
                OleDbDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbxNumPlan.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();


                //Remplissage cbxNom
                cbxNomBenef.Items.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [NomBenef] from tbBenefs group by [NomBenef];";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbxNomBenef.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();


                //Remplissage du cbxSte
                cbxSte.Items.Clear();
                Program.outils.getConnection().Open();
                requete = " Select [NomSociete] from tbBenefs group by [NomSociete];";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxSte.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();

                #endregion

                #region "Remplissage des données"
                //Remplissage txbxPlanChasse
                txbxPlanChasse.Text = cbxNumPlan.Text;

                //Remplissage du cbxCommuPrin
                Program.outils.getConnection().Open();
                requete = "Select [LibCommune] from tlCommunes where [NumCommune] in (Select [NumCommune_principale] from tbPlans where [NumPlan]=\"" + Convert.ToString(txbxPlanChasse.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxCommuPrin.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxIDK
                Program.outils.getConnection().Open();
                requete = "Select [LibMassif] from tlMassifs where [CdMassif] in (Select [CdMassifCour] from tbPlans where [NumPlan]=\"" + Convert.ToString(txbxPlanChasse.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxIDK.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage cbxBenef
                cbxBenef.Text = cbxNomBenef.Text;

                //Remplissage txbxBenef
                Program.outils.getConnection().Open();
                requete = "Select [PrenomBenef] from tbBenefs where [NomBenef] =\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxBenef.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage cbxCivilite
                Program.outils.getConnection().Open();
                requete = "Select [Sigle] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxCivilite.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxNomInfoBenef
                txbxNomInfoBenef.Text = cbxBenef.Text;

                //Remplissage txbxPrenom
                txbxPrenom.Text = txbxBenef.Text;

                //Remplissage cbxSociete
                cbxSociete.Items.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [NomSociete] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxSociete.Text = dr[0].ToString();
                    cbxSociete.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxRue
                Program.outils.getConnection().Open();
                requete = "Select [Rue] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxRue.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxLieuDit
                Program.outils.getConnection().Open();
                requete = "Select [ComplRue] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxLieuDit.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxCP
                Program.outils.getConnection().Open();
                requete = "Select [CodePostal] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxCP.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage cbxVille
                cbxVille.Items.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [Ville] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxVille.Text = dr[0].ToString();
                    cbxVille.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxTelephone
                Program.outils.getConnection().Open();
                requete = "Select [Telephone] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxTelephone.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxFax
                Program.outils.getConnection().Open();
                requete = "Select [Fax] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxFax.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxMail
                Program.outils.getConnection().Open();
                requete = "Select [Email] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxMail.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxPortable
                Program.outils.getConnection().Open();
                requete = "Select [portable] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxPortable.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxNotes
                Program.outils.getConnection().Open();
                requete = "Select [Notes] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxNotes.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpDateModif
                Program.outils.getConnection().Open();
                requete = "Select [DateModifBenef] from tbBenefs where [NomBenef]=\"" + Convert.ToString(cbxBenef.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpDateModif.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage du DGV Communes
                dgvCommunes.Rows.Clear();
                dgvCommunes.ColumnCount = 1;
                dgvCommunes.Columns[0].Name = "Nom des communes";
                dgvCommunes.AutoResizeColumns();

                Program.outils.getConnection().Open();
                requete = "Select [LibCommune] from tlCommunes where [NumCommune] in (Select [NumCommune] from tbCommunes where [NumPlan] = \"" + Convert.ToString(cbxNumPlan.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgvCommunes.Rows.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();


                //Remplissage txbxNotesInternes
                Program.outils.getConnection().Open();
                requete = "Select [NotesInternes] from tbPlans where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxNotesInternes.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpDateCreaPlan
                Program.outils.getConnection().Open();
                requete = "Select [DateCreationPlan] from tbPlans where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpDateCreaPlan.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpDateModifPlan
                Program.outils.getConnection().Open();
                requete = "Select [DateModifPlan] from tbPlans where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpDateModifPlan.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxDateSuppPlan
                Program.outils.getConnection().Open();
                requete = "Select [DateSupprPlan] from tbPlans where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxDateSuppPlan.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage cbxCampActu
                cbxCampActu.Items.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [LibCampagne] from tlCampagnes where [CdCampagne] in (Select [CdCampagne] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxCampActu.Text = dr[0].ToString();
                    cbxCampActu.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxBoisPrive
                Program.outils.getConnection().Open();
                requete = "Select [SurfaceBois] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxBoisPrive.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxBoisSoumis
                Program.outils.getConnection().Open();
                requete = "Select [SurfaceBoisSoumis] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxBoisSoumis.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxTTBois
                txbxTTBois.Text = Convert.ToString(Convert.ToInt32(txbxBoisPrive.Text) + Convert.ToInt32(txbxBoisSoumis.Text));

                //Remplissage txbxPlaine
                Program.outils.getConnection().Open();
                requete = "Select [SurfacePlaine] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxPlaine.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxTTSurfChasse
                txbxTTSurfChasse.Text = Convert.ToString(Convert.ToInt32(txbxTTBois.Text) + Convert.ToInt32(txbxPlaine.Text));


                //Remplissage txbxObservations
                Program.outils.getConnection().Open();
                requete = "Select [Observations] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxObservations.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpLastAttribution
                Program.outils.getConnection().Open();
                requete = "Select [DateDernAttrib] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpLastAttribution.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpCrea
                Program.outils.getConnection().Open();
                requete = "Select [DateCreationCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpCrea.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage dtpLastModif
                Program.outils.getConnection().Open();
                requete = "Select [DateModifCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dtpLastModif.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxNumLastAttribution
                Program.outils.getConnection().Open();
                requete = "Select [NumAttribution] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxNumLastAttribution.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxSecChevreuil
                Program.outils.getConnection().Open();
                requete = "Select [secteur_chevreuil] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxSecChevreuil.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxSecSanglier
                Program.outils.getConnection().Open();
                requete = "Select [secteur_sanglier] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxSecSanglier.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage txbxSecCerf
                Program.outils.getConnection().Open();
                requete = "Select [secteur_cerf] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    txbxSecCerf.Text = dr[0].ToString();
                }
                Program.outils.getConnection().Close();

                //Remplissage cbxNomGroupement
                cbxNomGroupement.Items.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [LibMassif] from tlMassifs where [SecteurMassif] in (Select [CdMassifCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\"));";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    cbxNomGroupement.Text = dr[0].ToString();
                    cbxNomGroupement.Items.Add(dr[0].ToString());
                }
                Program.outils.getConnection().Close();

                //Remplissage dgvEspeces
                dgvEspeces.Rows.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [LibEspece] from tlEspeces where [CdEspece] in (Select [CdEspece] from tbEspeces where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\"));";
                string requete1 = "Select [NbEstime] from tbEspeces where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";

                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                OleDbCommand cmd1 = new OleDbCommand(requete1, Program.outils.getConnection());
                OleDbDataReader dr1 = cmd1.ExecuteReader();

                dgvEspeces.ColumnCount = 2;
                dgvEspeces.Columns[0].Name = "Nom de l'espèce";
                dgvEspeces.Columns[1].Name = "Estimé";

                string[] ah;

                while (dr.Read() && dr1.Read())
                {
                    ah = new string[] { dr[0].ToString(), dr1[0].ToString() };
                    dgvEspeces.Rows.Add(ah);
                }
                Program.outils.getConnection().Close();

                //Remplissage dgvBraceletParGibier
                dgvBraceletParGibier.Rows.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
                requete1 = "Select MIN([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
                string requete2 = "Select MAX([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                cmd1.CommandText = requete1;
                dr1 = cmd1.ExecuteReader();
                OleDbCommand cmd2 = new OleDbCommand(requete2, Program.outils.getConnection());
                OleDbDataReader dr2 = cmd2.ExecuteReader();

                dgvBraceletParGibier.ColumnCount = 3;
                dgvBraceletParGibier.Columns[0].Name = "Nom de l'espèce";
                dgvBraceletParGibier.Columns[1].Name = "N° min";
                dgvBraceletParGibier.Columns[2].Name = "N° max";

                while (dr.Read() && dr1.Read() && dr2.Read())
                {
                    ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString() };
                    dgvBraceletParGibier.Rows.Add(ah);
                }
                Program.outils.getConnection().Close();

                //Remplissage dgvGibiers
                dgvGibiers.Rows.Clear();
                Program.outils.getConnection().Open();
                requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
                requete1 = "Select [NbDemande] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                requete2 = "Select [NbAvisFDCY] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete3 = "Select [NbAvisONF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete4 = "Select [NbAvisDDAF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete5 = "Select [AccordeSousReserve] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete6 = "Select [NbAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete7 = "Select [NbRealise] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete8 = "Select [NbRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete9 = "Select [NbAvisFDCYRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete10 = "Select [NbAvisONFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete11 = "Select [NbAvisDDAFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
                string requete12 = "Select [NbSelectionAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";

                cmd.CommandText = requete;
                dr = cmd.ExecuteReader();
                cmd1.CommandText = requete1;
                dr1 = cmd1.ExecuteReader();
                cmd2.CommandText = requete2;
                dr2 = cmd2.ExecuteReader();
                OleDbCommand cmd3 = new OleDbCommand(requete3, Program.outils.getConnection());
                OleDbDataReader dr3 = cmd3.ExecuteReader();
                OleDbCommand cmd4 = new OleDbCommand(requete4, Program.outils.getConnection());
                OleDbDataReader dr4 = cmd4.ExecuteReader();
                OleDbCommand cmd5 = new OleDbCommand(requete5, Program.outils.getConnection());
                OleDbDataReader dr5 = cmd5.ExecuteReader();
                OleDbCommand cmd6 = new OleDbCommand(requete6, Program.outils.getConnection());
                OleDbDataReader dr6 = cmd6.ExecuteReader();
                OleDbCommand cmd7 = new OleDbCommand(requete7, Program.outils.getConnection());
                OleDbDataReader dr7 = cmd7.ExecuteReader();
                OleDbCommand cmd8 = new OleDbCommand(requete8, Program.outils.getConnection());
                OleDbDataReader dr8 = cmd8.ExecuteReader();
                OleDbCommand cmd9 = new OleDbCommand(requete9, Program.outils.getConnection());
                OleDbDataReader dr9 = cmd9.ExecuteReader();
                OleDbCommand cmd10 = new OleDbCommand(requete10, Program.outils.getConnection());
                OleDbDataReader dr10 = cmd10.ExecuteReader();
                OleDbCommand cmd11 = new OleDbCommand(requete11, Program.outils.getConnection());
                OleDbDataReader dr11 = cmd11.ExecuteReader();
                OleDbCommand cmd12 = new OleDbCommand(requete12, Program.outils.getConnection());
                OleDbDataReader dr12 = cmd12.ExecuteReader();


                dgvGibiers.ColumnCount = 13;
                dgvGibiers.Columns[0].Name = "Nom de l'espèce";
                dgvGibiers.Columns[1].Name = "Dem.";
                dgvGibiers.Columns[2].Name = "FDCY";
                dgvGibiers.Columns[3].Name = "ONF";
                dgvGibiers.Columns[4].Name = "DDAF";
                dgvGibiers.Columns[5].Name = "Acc ss réserve";
                dgvGibiers.Columns[6].Name = "Acc.";
                dgvGibiers.Columns[7].Name = "Réal";
                dgvGibiers.Columns[8].Name = "Nb";
                dgvGibiers.Columns[9].Name = "FDCY";
                dgvGibiers.Columns[10].Name = "ONF";
                dgvGibiers.Columns[11].Name = "DDAF";
                dgvGibiers.Columns[12].Name = "Acc.";

                while (dr.Read() && dr1.Read() && dr2.Read() && dr3.Read() && dr4.Read() && dr5.Read() && dr6.Read() && dr7.Read() && dr8.Read() && dr9.Read() && dr10.Read() && dr11.Read() && dr12.Read())
                {
                    ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString(), dr3[0].ToString(), dr4[0].ToString(), dr5[0].ToString(), dr6[0].ToString(), dr7[0].ToString(), dr8[0].ToString(), dr9[0].ToString(), dr10[0].ToString(), dr11[0].ToString(), dr12[0].ToString() };
                    dgvGibiers.Rows.Add(ah);
                }
                Program.outils.getConnection().Close();
                #endregion
            }
        }

        private void dgvEspeces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            #region "Update de la sélection"
            //Remplissage dgvBraceletParGibier
            dgvBraceletParGibier.Rows.Clear();
            Program.outils.getConnection().Open();
            string requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
            string requete1 = "Select MIN([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
            string requete2 = "Select MAX([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            OleDbCommand cmd1 = new OleDbCommand(requete1, Program.outils.getConnection());
            OleDbDataReader dr1 = cmd1.ExecuteReader();
            OleDbCommand cmd2 = new OleDbCommand(requete2, Program.outils.getConnection());
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            dgvBraceletParGibier.ColumnCount = 3;
            dgvBraceletParGibier.Columns[0].Name = "Nom de l'espèce";
            dgvBraceletParGibier.Columns[1].Name = "N° min";
            dgvBraceletParGibier.Columns[2].Name = "N° max";

            string[] ah;

            while (dr.Read() && dr1.Read() && dr2.Read())
            {
                ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString() };
                dgvBraceletParGibier.Rows.Add(ah);
            }
            Program.outils.getConnection().Close();

            //Remplissage dgvGibiers
            dgvGibiers.Rows.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
            requete1 = "Select [NbDemande] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            requete2 = "Select [NbAvisFDCY] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete3 = "Select [NbAvisONF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete4 = "Select [NbAvisDDAF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete5 = "Select [AccordeSousReserve] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete6 = "Select [NbAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete7 = "Select [NbRealise] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete8 = "Select [NbRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete9 = "Select [NbAvisFDCYRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete10 = "Select [NbAvisONFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete11 = "Select [NbAvisDDAFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete12 = "Select [NbSelectionAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";

            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            cmd1.CommandText = requete1;
            dr1 = cmd1.ExecuteReader();
            cmd2.CommandText = requete2;
            dr2 = cmd2.ExecuteReader();
            OleDbCommand cmd3 = new OleDbCommand(requete3, Program.outils.getConnection());
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            OleDbCommand cmd4 = new OleDbCommand(requete4, Program.outils.getConnection());
            OleDbDataReader dr4 = cmd4.ExecuteReader();
            OleDbCommand cmd5 = new OleDbCommand(requete5, Program.outils.getConnection());
            OleDbDataReader dr5 = cmd5.ExecuteReader();
            OleDbCommand cmd6 = new OleDbCommand(requete6, Program.outils.getConnection());
            OleDbDataReader dr6 = cmd6.ExecuteReader();
            OleDbCommand cmd7 = new OleDbCommand(requete7, Program.outils.getConnection());
            OleDbDataReader dr7 = cmd7.ExecuteReader();
            OleDbCommand cmd8 = new OleDbCommand(requete8, Program.outils.getConnection());
            OleDbDataReader dr8 = cmd8.ExecuteReader();
            OleDbCommand cmd9 = new OleDbCommand(requete9, Program.outils.getConnection());
            OleDbDataReader dr9 = cmd9.ExecuteReader();
            OleDbCommand cmd10 = new OleDbCommand(requete10, Program.outils.getConnection());
            OleDbDataReader dr10 = cmd10.ExecuteReader();
            OleDbCommand cmd11 = new OleDbCommand(requete11, Program.outils.getConnection());
            OleDbDataReader dr11 = cmd11.ExecuteReader();
            OleDbCommand cmd12 = new OleDbCommand(requete12, Program.outils.getConnection());
            OleDbDataReader dr12 = cmd12.ExecuteReader();


            dgvGibiers.ColumnCount = 13;
            dgvGibiers.Columns[0].Name = "Nom de l'espèce";
            dgvGibiers.Columns[1].Name = "Dem.";
            dgvGibiers.Columns[2].Name = "FDCY";
            dgvGibiers.Columns[3].Name = "ONF";
            dgvGibiers.Columns[4].Name = "DDAF";
            dgvGibiers.Columns[5].Name = "Acc ss réserve";
            dgvGibiers.Columns[6].Name = "Acc.";
            dgvGibiers.Columns[7].Name = "Réal";
            dgvGibiers.Columns[8].Name = "Nb";
            dgvGibiers.Columns[9].Name = "FDCY";
            dgvGibiers.Columns[10].Name = "ONF";
            dgvGibiers.Columns[11].Name = "DDAF";
            dgvGibiers.Columns[12].Name = "Acc.";

            while (dr.Read() && dr1.Read() && dr2.Read() && dr3.Read() && dr4.Read() && dr5.Read() && dr6.Read() && dr7.Read() && dr8.Read() && dr9.Read() && dr10.Read() && dr11.Read() && dr12.Read())
            {
                ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString(), dr3[0].ToString(), dr4[0].ToString(), dr5[0].ToString(), dr6[0].ToString(), dr7[0].ToString(), dr8[0].ToString(), dr9[0].ToString(), dr10[0].ToString(), dr11[0].ToString(), dr12[0].ToString() };
                dgvGibiers.Rows.Add(ah);
            }
            Program.outils.getConnection().Close();
            #endregion
        }

        private void btNewCampagne_Click(object sender, EventArgs e)
        {

            //Lancement de l'extension Access + docu = https://www.c-sharpcorner.com/blogs/how-to-create-an-access-database-by-using-adox-and-visual-c-sharp-net

            ADOX.Catalog cat = new ADOX.Catalog();
            cat.Create(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\BraceletBDD" + Convert.ToString(Program.outils.getCampagneActuelle()) + ".accdb; Jet OLEDB:Engine Type=5");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region "Rafraichissement des données"
            //Remplissage txbxBoisPrive
            Program.outils.getConnection().Open();
            string requete = "Select [SurfaceBois] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            OleDbCommand cmd = new OleDbCommand(requete,Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxBoisPrive.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxBoisSoumis
            Program.outils.getConnection().Open();
            requete = "Select [SurfaceBoisSoumis] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxBoisSoumis.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxTTBois
            txbxTTBois.Text = Convert.ToString(Convert.ToInt32(txbxBoisPrive.Text) + Convert.ToInt32(txbxBoisSoumis.Text));

            //Remplissage txbxPlaine
            Program.outils.getConnection().Open();
            requete = "Select [SurfacePlaine] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxPlaine.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxTTSurfChasse
            txbxTTSurfChasse.Text = Convert.ToString(Convert.ToInt32(txbxTTBois.Text) + Convert.ToInt32(txbxPlaine.Text));


            //Remplissage txbxObservations
            Program.outils.getConnection().Open();
            requete = "Select [Observations] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxObservations.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage dtpLastAttribution
            Program.outils.getConnection().Open();
            requete = "Select [DateDernAttrib] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dtpLastAttribution.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage dtpCrea
            Program.outils.getConnection().Open();
            requete = "Select [DateCreationCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dtpCrea.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage dtpLastModif
            Program.outils.getConnection().Open();
            requete = "Select [DateModifCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dtpLastModif.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxNumLastAttribution
            Program.outils.getConnection().Open();
            requete = "Select [NumAttribution] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxNumLastAttribution.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxSecChevreuil
            Program.outils.getConnection().Open();
            requete = "Select [secteur_chevreuil] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxSecChevreuil.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxSecSanglier
            Program.outils.getConnection().Open();
            requete = "Select [secteur_sanglier] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxSecSanglier.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage txbxSecCerf
            Program.outils.getConnection().Open();
            requete = "Select [secteur_cerf] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                txbxSecCerf.Text = dr[0].ToString();
            }
            Program.outils.getConnection().Close();

            //Remplissage cbxNomGroupement
            cbxNomGroupement.Items.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [LibMassif] from tlMassifs where [SecteurMassif] in (Select [CdMassifCamp] from tbCampagnes where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\"));";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbxNomGroupement.Text = dr[0].ToString();
                cbxNomGroupement.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            //Remplissage dgvEspeces
            dgvEspeces.Rows.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [LibEspece] from tlEspeces where [CdEspece] in (Select [CdEspece] from tbEspeces where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\"));";
            string requete1 = "Select [NbEstime] from tbEspeces where [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";

            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            OleDbCommand cmd1 = new OleDbCommand(requete1, Program.outils.getConnection());
            OleDbDataReader dr1 = cmd1.ExecuteReader();

            dgvEspeces.ColumnCount = 2;
            dgvEspeces.Columns[0].Name = "Nom de l'espèce";
            dgvEspeces.Columns[1].Name = "Estimé";

            string[] ah;

            while (dr.Read() && dr1.Read())
            {
                ah = new string[] { dr[0].ToString(), dr1[0].ToString() };
                dgvEspeces.Rows.Add(ah);
            }
            Program.outils.getConnection().Close();

            //Remplissage dgvBraceletParGibier
            dgvBraceletParGibier.Rows.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
            requete1 = "Select MIN([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
            string requete2 = "Select MAX([NumBracelet]) from tbBracelets where [CdGibier] in (Select [CdGibier] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\")) AND [NumPlan]=" + Convert.ToInt32(cbxNumPlan.Text) + ";";
            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            cmd1.CommandText = requete1;
            dr1 = cmd1.ExecuteReader();
            OleDbCommand cmd2 = new OleDbCommand(requete2, Program.outils.getConnection());
            OleDbDataReader dr2 = cmd2.ExecuteReader();

            dgvBraceletParGibier.ColumnCount = 3;
            dgvBraceletParGibier.Columns[0].Name = "Nom de l'espèce";
            dgvBraceletParGibier.Columns[1].Name = "N° min";
            dgvBraceletParGibier.Columns[2].Name = "N° max";

            while (dr.Read() && dr1.Read() && dr2.Read())
            {
                ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString() };
                dgvBraceletParGibier.Rows.Add(ah);
            }
            Program.outils.getConnection().Close();

            //Remplissage dgvGibiers
            dgvGibiers.Rows.Clear();
            Program.outils.getConnection().Open();
            requete = "Select [LibGibier] from tlGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\");";
            requete1 = "Select [NbDemande] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            requete2 = "Select [NbAvisFDCY] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete3 = "Select [NbAvisONF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete4 = "Select [NbAvisDDAF] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete5 = "Select [AccordeSousReserve] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete6 = "Select [NbAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete7 = "Select [NbRealise] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete8 = "Select [NbRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete9 = "Select [NbAvisFDCYRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete10 = "Select [NbAvisONFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete11 = "Select [NbAvisDDAFRecours] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";
            string requete12 = "Select [NbSelectionAccorde] from tbGibiers where [CdEspece] in (Select [CdEspece] from tlEspeces where [LibEspece] =\"" + Convert.ToString(dgvEspeces.CurrentCell.Value) + "\") AND [NumPlan]=\"" + Convert.ToString(cbxNumPlan.Text) + "\" AND [CdCampagne] in (Select [CdCampagne] from tlCampagnes where [LibCampagne]=\"" + Convert.ToString(cbxCampActu.Text) + "\");";

            cmd.CommandText = requete;
            dr = cmd.ExecuteReader();
            cmd1.CommandText = requete1;
            dr1 = cmd1.ExecuteReader();
            cmd2.CommandText = requete2;
            dr2 = cmd2.ExecuteReader();
            OleDbCommand cmd3 = new OleDbCommand(requete3, Program.outils.getConnection());
            OleDbDataReader dr3 = cmd3.ExecuteReader();
            OleDbCommand cmd4 = new OleDbCommand(requete4, Program.outils.getConnection());
            OleDbDataReader dr4 = cmd4.ExecuteReader();
            OleDbCommand cmd5 = new OleDbCommand(requete5, Program.outils.getConnection());
            OleDbDataReader dr5 = cmd5.ExecuteReader();
            OleDbCommand cmd6 = new OleDbCommand(requete6, Program.outils.getConnection());
            OleDbDataReader dr6 = cmd6.ExecuteReader();
            OleDbCommand cmd7 = new OleDbCommand(requete7, Program.outils.getConnection());
            OleDbDataReader dr7 = cmd7.ExecuteReader();
            OleDbCommand cmd8 = new OleDbCommand(requete8, Program.outils.getConnection());
            OleDbDataReader dr8 = cmd8.ExecuteReader();
            OleDbCommand cmd9 = new OleDbCommand(requete9, Program.outils.getConnection());
            OleDbDataReader dr9 = cmd9.ExecuteReader();
            OleDbCommand cmd10 = new OleDbCommand(requete10, Program.outils.getConnection());
            OleDbDataReader dr10 = cmd10.ExecuteReader();
            OleDbCommand cmd11 = new OleDbCommand(requete11, Program.outils.getConnection());
            OleDbDataReader dr11 = cmd11.ExecuteReader();
            OleDbCommand cmd12 = new OleDbCommand(requete12, Program.outils.getConnection());
            OleDbDataReader dr12 = cmd12.ExecuteReader();


            dgvGibiers.ColumnCount = 13;
            dgvGibiers.Columns[0].Name = "Nom de l'espèce";
            dgvGibiers.Columns[1].Name = "Dem.";
            dgvGibiers.Columns[2].Name = "FDCY";
            dgvGibiers.Columns[3].Name = "ONF";
            dgvGibiers.Columns[4].Name = "DDAF";
            dgvGibiers.Columns[5].Name = "Acc ss réserve";
            dgvGibiers.Columns[6].Name = "Acc.";
            dgvGibiers.Columns[7].Name = "Réal";
            dgvGibiers.Columns[8].Name = "Nb";
            dgvGibiers.Columns[9].Name = "FDCY";
            dgvGibiers.Columns[10].Name = "ONF";
            dgvGibiers.Columns[11].Name = "DDAF";
            dgvGibiers.Columns[12].Name = "Acc.";

            while (dr.Read() && dr1.Read() && dr2.Read() && dr3.Read() && dr4.Read() && dr5.Read() && dr6.Read() && dr7.Read() && dr8.Read() && dr9.Read() && dr10.Read() && dr11.Read() && dr12.Read())
            {
                ah = new string[] { dr[0].ToString(), dr1[0].ToString(), dr2[0].ToString(), dr3[0].ToString(), dr4[0].ToString(), dr5[0].ToString(), dr6[0].ToString(), dr7[0].ToString(), dr8[0].ToString(), dr9[0].ToString(), dr10[0].ToString(), dr11[0].ToString(), dr12[0].ToString() };
                dgvGibiers.Rows.Add(ah);
            }
            Program.outils.getConnection().Close();
            #endregion
        }

        private void Saisie_Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
