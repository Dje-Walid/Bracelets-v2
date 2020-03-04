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

namespace Bracelet
{
    public partial class Action_Form3_Suite : Form
    {
        public Action_Form3_Suite()
        {
            InitializeComponent();
        }
        Outils a = new Outils();
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

        private void Action_Form3_Suite_Load(object sender, EventArgs e)
        {
            //Remplissage du cbxMasIN
            Program.outils.getConnection().Open();
            string requete = "Select [LibMassif] from tlMassifs";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbxMasIn.Items.Add(dr[0].ToString());
            }
            Program.outils.getConnection().Close();


        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txbxSecIn.Text = "";
            txbxSecEx.Text = "";

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            a.annuler(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
