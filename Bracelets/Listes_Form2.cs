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
    public partial class Listes_Form2 : Form
    {
        public Listes_Form2()
        {
            InitializeComponent();
        }

        private void Listes_Form2_Load(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Url = new Uri("https://www.microsoft.com/fr-fr/");

        }
    }
}
