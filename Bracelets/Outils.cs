using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using IniParser;
using IniParser.Model;


namespace Bracelet
{
    class Outils
    {
        private OleDbConnection connection;
        private FileIniDataParser config;
        public Outils()
        {
            this.connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BraceletBDD.accdb; Persist Security Info=False;");
            this.config = new FileIniDataParser();
        }

        public void annuler(Form a)
        {
            DialogResult resulta;
            resulta = MessageBox.Show("Êtes-vous sûr de vouloir annuler ", "AVERTISSEMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resulta == System.Windows.Forms.DialogResult.OK)
            {
                a.Close();
            }
            else
            {

            }
        }
        public void allerMenu(Form a)
        {
            DialogResult resulta;
            resulta = MessageBox.Show("Êtes-vous sûr de vouloir sortir ? ", "AVERTISSEMENT", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (resulta == System.Windows.Forms.DialogResult.OK)
            {
                Menu menu = new Menu();
                menu.Show();
                a.Close();
            }
            else
            {

            }
        }
        public void effacer(Form a)
        {
            foreach (Control c in a.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = String.Empty;
                }
            }
        }

        public void lien(Form a, Form nomDeLaForm)
        {
            a = new Form();
            nomDeLaForm = new Form();
            nomDeLaForm.Show();
        }

        public void setCampagneActuelle(string date)
        {
            IniData data = this.getConfig();
            data["Info"]["CampagneActu"] = date;
            this.config.WriteFile("Config.ini", data);
        }

        public string getCampagneActuelle()
        {
            return this.getConfig()["Info"]["CampagneActu"];
        }

        public OleDbConnection getConnection()
        {
            return this.connection;
        }
        
        public void testConnection()
        {
            try
            {
                this.connection.Open();
                MessageBox.Show("Connexion fonctionne");
                this.connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Connexion ne fonctionne pas" + ex);
            }
        }

        public IniData getConfig()
        {
            IniData data = this.config.ReadFile("Config.ini");
            return data;
        }


    }
}
