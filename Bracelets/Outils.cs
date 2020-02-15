using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Bracelet
{
    class Outils
    {
        public Outils()
        { }
        public static Outils outils = new Outils();

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
    }
}
