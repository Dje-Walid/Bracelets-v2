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
        
        //Constructeur qui demande aucun arguments
        public Outils()
        {
            this.connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BraceletBDD.accdb; Persist Security Info=False;");
            this.config = new FileIniDataParser();
        }

        //Cette méthode permet de fermer un form sans utiliser la croix en haut a droite, elle demande comme argument le form a fermer
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

        //Cette méthode va permettre d'envoyer l'utilisateur vers le menu, elle demande comme argument le form qui va être remplacer par le menu
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

        //Cette méthode permet d'effacer toutes les valeurs présentent dans un form, elle demande comme argument le form où la suppression des données va avoir lieu
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

        //Cette méthode permet de former un form et d'en ouvrir un autre comme le système d'un lien, elle demande donc comme argument le form a fermer et celui à ouvrir
        public void lien(Form a, Form nomDeLaForm)
        {
            a = new Form();
            nomDeLaForm = new Form();
            nomDeLaForm.Show();
        }

        //C'est un setter pour la Campagne Actuelle présente sur Config.ini, elle a comme argument la valeur à set dans la Campagne Actuelle
        public void setCampagneActuelle(string date)
        {
            IniData data = this.getConfig();
            data["Info"]["CampagneActu"] = date;
            this.config.WriteFile("Config.ini", data);
        }

        //C'est un getter pour la Campagne Actuelle présente sur Config.ini
        public string getCampagneActuelle()
        {
            return this.getConfig()["Info"]["CampagneActu"];
        }

        //Permet de récupérer l'objet qui va permettre de réaliser les requêtes SQL
        public OleDbConnection getConnection()
        {
            return this.connection;
        }
        
        //Cette méthode va vous faire apparaître un message confirmant si la connexion est effectuée
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

        //Cette méthode permet de se connecter et de récuperer le fichier Config.ini afin d'y faire des modifications
        public IniData getConfig()
        {
            IniData data = this.config.ReadFile("Config.ini");
            return data;
        }

        public OleDbDataReader requeteSQL(string Table, string Attribut)
        {
            Program.outils.getConnection().Open();
            string requete = "Select [" + Attribut + "] from " + Table + ";";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();
            Program.outils.getConnection().Close();

            return dr;
        }

        public OleDbDataReader requeteSQL(string Table, string Attribut, string AttributCondition,string Condition,string TypeCondition)
        {
            string requete = "1";
            OleDbCommand cmd = new OleDbCommand(requete, Program.outils.getConnection());
            OleDbDataReader dr = cmd.ExecuteReader();

            switch (TypeCondition)
            {
                case "=":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "=\"" + Condition + "\";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "in":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "in (\"" + Condition + "\");";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "<":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "<" + Condition + ";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case ">":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + ">" + Condition + ";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "<=":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "<=" + Condition + ";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case ">=":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + ">=" + Condition + ";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "likeDebut":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "LIKE \"%" + Condition + "\";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;
                case "likeFin":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "LIKE \"" + Condition + "%\";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "likeMilieu":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "LIKE \"%" + Condition + "%\";";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;

                case "isNull":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "IS NULL;";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;
                case "isNotNull":
                    requete = "Select [" + Attribut + "] from " + Table + " where " + AttributCondition + "IS NOT NULL;";
                    cmd.CommandText = requete;
                    dr = cmd.ExecuteReader();
                    break;
            }

            return dr;
        }


    }
}
