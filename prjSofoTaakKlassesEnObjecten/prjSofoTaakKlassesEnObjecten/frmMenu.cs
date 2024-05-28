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

            //knoppen vergrendelen die gebruiker bij opstarten niet kan gebruiken
            btnBekijk.Enabled = false;
            btnVerwijderContactpersoon.Enabled = false;
            btnWijzigContactpersoon.Enabled = false;

        }

        private void btnNieuwContactpersoon_Click(object sender, EventArgs e)
        {

        }

        private void btnWijzigContactpersoon_Click(object sender, EventArgs e)
        {

        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {

        }

        private void btnVerwijderContactpersoon_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings();

            frmSettings.Show();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //enige vereiste --> naam
            //rest is optioneel
            if (txtNaam.Text.Trim() == string.Empty || txtVoornaam.Text.Trim() == string.Empty)
            {
                //niet in orde --> waarschuwing
                MessageBox.Show("Naam en voornaam zijn verplichte velden. Gelieve hier iets in te geven.", "Error: Invoer leeg", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //invoer is correct --> opslaan in klasse
                //naam en voornaam zijn niet leeg --> in nieuw object
                //de rest checken
                Contactpersoon contactpersoon = new Contactpersoon();

                contactpersoon.Naam = txtNaam.Text;
                contactpersoon.Voornaam = txtVoornaam.Text;

                if (txtTelefoonnummer.Text.Trim() != string.Empty)
                {
                    contactpersoon.Telefoonnummer = txtTelefoonnummer.Text;
                }
                if (txtEmailadres.Text.Trim() != string.Empty)
                {
                    contactpersoon.Emailadres = txtEmailadres.Text;
                }
                if (txtAdres.Text.Trim() != string.Empty)
                {
                    contactpersoon.Straatnaam = txtAdres.Text;
                }
                if (txtHuisnummer.Text.Trim() != string.Empty)
                {
                    contactpersoon.Huisnummer = txtHuisnummer.Text;
                }

                if (rdbJa.Checked)
                {
                    contactpersoon.Appartement = true;
                }
                else
                {
                    contactpersoon.Appartement = false;
                }

                if (txtBus.Text.Trim() != string.Empty)
                {
                    contactpersoon.Bus = txtBus.Text;
                }
                if (txtLand.Text.Trim() != string.Empty)
                {
                    contactpersoon.Land = txtLand.Text;
                }

                //alle properties van het contactpersoon zijn nu aangevuld (behalve de foto natuurlijk)

                //object / contactpersoon toevoegen aan array
                frmMenu frmMenu = new frmMenu();
                frmMenu.contacten[frmMenu.intIndexContactpersoon, 0] = contactpersoon;

                contactpersoon.reloadLsbContactpersonen();

                //index van contactpersoon + 1
                frmMenu.intIndexContactpersoon++;
            }
        }

        private void linklabelGithubRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DaanHautekeete/Opdracht-SOFO-Arrays---Klassen---Objecten");
        }
    }
}
