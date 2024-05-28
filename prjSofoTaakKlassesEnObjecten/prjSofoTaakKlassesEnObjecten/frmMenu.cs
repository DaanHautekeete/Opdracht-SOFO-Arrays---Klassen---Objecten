using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSofoTaakKlassesEnObjecten
{
    public partial class frmMenu : Form
    {
        public string nieuwContactAanmakenTitel = "NIEUW CONTACT AANMAKEN";
        public int intNieuwContactIndex = 0;

        //array aanmaken voor alle objecten
        //kolom 1 => namen van de contactpersonen
        //kolom 2 => foto's van de contactpersonen
        public object[,] contacten;

        //var aanmaken voor aantal personen in array
        public int intIndexContactpersoon = 0;

        public frmMenu()
        {
            InitializeComponent();

            //code om knoppen te laten veranderen van kleur bij hover
            btnNieuwContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnWijzigContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBekijk.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnVerwijderContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Gray;

            //knoppen vergrendelen die gebruiker bij opstarten niet kan gebruiken
            btnBekijk.Enabled = false;
            btnVerwijderContactpersoon.Enabled = false;
            btnWijzigContactpersoon.Enabled = false;
        }

        private void btnNieuwContactpersoon_Click(object sender, EventArgs e)
        {
            frmEditOrNew frmEditOrNew = new frmEditOrNew();
            frmEditOrNew.Show();
        }

        private void btnWijzigContactpersoon_Click(object sender, EventArgs e)
        {

        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            frmBekijk frmBekijk = new frmBekijk();

            frmBekijk.Show();
        }

        private void btnVerwijderContactpersoon_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();

            frmSettings.Show();
        }

        public void reloadLsb()
        {
            lsbContactpersonen.Items.Clear();
            for (int i = 0; i <= contacten.GetUpperBound(0); i++)
            {
                //Alle items toevoegen
            }
        }
    }
}
