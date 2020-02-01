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
            nomDeLaForm.Show();
        }
    }
}
