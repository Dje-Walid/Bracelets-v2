using System;
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
            Program.outils.getConnection().Open();
            string requete = "Select [CdMassif] from tlMassifs where [LibMassif] =\"" + Convert.ToString(cbxMasIn.Text) + "\";";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();

            if (txbxMassIn2.Text == "")
            {
                while (dr.Read())
                {
                    txbxMassIn2.Text = dr[0].ToString();
                    Action_Form3_Suite.MassifIn.Add(dr[0].ToString());
                }
            }
            else
            {
                while (dr.Read())
                {
                    txbxMassIn2.Text = txbxMassIn2.Text + "," + dr[0].ToString();
                    Action_Form3_Suite.MassifIn.Add("," + dr[0].ToString());
                }
            }

            Program.outils.getConnection().Close();





        }

        private void Action_Form1_suite_Load(object sender, EventArgs e)
        {
            Program.outils.getConnection().Open();
            string requete = "Select [LibMassif] from tlMassifs";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbxMasIn.Items.Add(dr[0].ToString());
                cbxMasEx.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();

            Action_Form3_Suite.MassifEx.Clear();
            Action_Form3_Suite.MassifIn.Clear();

        }

        private void btEffacer_Click(object sender, EventArgs e)
        {
            txbxSecIn1.Text = "";
            txbxMassIn2.Text = "";
            txbxSecEx1.Text = "";
            txbxMassEx2.Text = "";

            Action_Form3_Suite.MassifEx.Clear();
            Action_Form3_Suite.MassifIn.Clear();
        }

        private void txbxSecEx2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxMasEx_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.outils.getConnection().Open();
            string requete = "Select [CdMassif] from tlMassifs where [LibMassif] =\"" + Convert.ToString(cbxMasEx.Text) + "\";";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();

            if (txbxMassEx2.Text == "")
            {
                while (dr.Read())
                {
                    txbxMassEx2.Text = dr[0].ToString();
                    Action_Form3_Suite.MassifEx.Add(dr[0].ToString());
                }
            }
            else
            {
                while (dr.Read())
                {
                    txbxMassEx2.Text = txbxMassEx2.Text + "," + dr[0].ToString();
                    Action_Form3_Suite.MassifEx.Add(dr[0].ToString());
                }
            }

            Program.outils.getConnection().Close();
        }

        private void Action_Form1_suite_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
