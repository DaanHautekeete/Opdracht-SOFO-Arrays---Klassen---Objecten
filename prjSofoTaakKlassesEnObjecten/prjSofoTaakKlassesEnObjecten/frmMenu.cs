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
        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Modulaire variablen
        ///|/////////////////////////////////////////////////////////////////////////////////////
        //array aanmaken voor alle objecten
        //kolom 1 => object van contactpersoon
        //kolom 2 => foto's van de contactpersonen
        object[,] arrContacten;

        //var aanmaken voor aantal personen in array
        int intIndexContactpersoon = 0;

        //var voor index geselecteerd contactpersoon
        int intIndexGeselecteerdContactpersoon;

        public frmMenu()
        {
            InitializeComponent();

            //arrContacten initialiseren met een geschat aantal contactpersonen
            arrContacten = new object[100, 2];

            //knoppen vergrendelen die gebruiker bij opstarten niet kan gebruiken
            btnBekijk.Enabled = false;
            btnVerwijderContactpersoon.Enabled = false;
            btnWijzigContactpersoon.Enabled = false;

            //groupboxen locken bij opstarten
            grpbMakenWijzigen.Enabled = false;
        }

        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Alle knoppen en listboxen
        ///|/////////////////////////////////////////////////////////////////////////////////////

        private void btnNieuwContactpersoon_Click(object sender, EventArgs e)
        {
            //groupbox unlocken
            grpbMakenWijzigen.Enabled = true;
            grpbMakenWijzigen.Text = "Nieuw contactpersoon";

            //standaardwaarde meegeven voor keuze appartement
            rdbMeerdereBussenFalse.Checked = true;
        }

        private void btnWijzigContactpersoon_Click(object sender, EventArgs e)
        {
            //hier komt code om contactpersoon te wijzigen
            //moeten controleren welke index er geselecteerd is in listbox => index gebruiken voor array met alle objecten
            //eigenschappen moeten aangepast worden en opnieuw in dezelfde index kunnen opgeslagen worden

        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            //hier komt de code om het contactpersoon te bekijken => niets aanpassen
            //alle eigenschappen worden ingevuld in de textboxen => textboxen niet kunnen aanpassen

        }

        private void btnVerwijderContactpersoon_Click(object sender, EventArgs e)
        {
            //messagebox weergeven met vraag
            DialogResult dlgKeuzeVerwijderen = MessageBox.Show("Bent u zeker dat u alle contactpersonen wilt verwijderen?","Lijst met contactpersonen verwijderen?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dlgKeuzeVerwijderen == DialogResult.Yes)
            {
                //array met contactpersonen leegmaken
                Array.Clear(arrContacten,0,arrContacten.GetUpperBound(0));

                //listboxen met contactpersonen en informatie legen
                lsbBasisinfoContactpersonen.Items.Clear();
                lsbContactpersonen.Items.Clear();

                //knoppen uitschakelen
                btnVerwijderContactpersoon.Enabled = false;
                btnWijzigContactpersoon.Enabled = false;
                btnBekijk.Enabled = false;
            }
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

                contactpersoon.VolledigeNaam = contactpersoon.Naam + " " + contactpersoon.Voornaam;

                if (txtTelefoonnummer.Text.Trim() != string.Empty)
                {
                    contactpersoon.Telefoonnummer = txtTelefoonnummer.Text;
                }
                if (txtEmailadres.Text.Trim() != string.Empty)
                {
                    contactpersoon.Emailadres = txtEmailadres.Text;
                }
                if (txtStraatnaam.Text.Trim() != string.Empty)
                {
                    contactpersoon.Straatnaam = txtStraatnaam.Text;
                }
                if (txtHuisnummer.Text.Trim() != string.Empty)
                {
                    contactpersoon.Huisnummer = txtHuisnummer.Text;
                }

                if (rdbMeerdereBussenTrue.Checked)
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

                arrContacten[intIndexContactpersoon, 0] = contactpersoon;

                // Voeg de naam van de contactpersoon toe aan de listbox
                lsbContactpersonen.Items.Add(contactpersoon.VolledigeNaam.ToString());

                // Verhoog de index voor de volgende contactpersoon
                intIndexContactpersoon++;

                //alle invoer verwijderen en groupbox vergrendelen
                InvoerResetten();

                //knop voor alle contactpersonen te wissen, inschakelen
                btnVerwijderContactpersoon.Enabled = true;

                //properties van groupbox wijzigen
                grpbMakenWijzigen.Text = "Nieuw/wijzig/lees contactpersoon";
                grpbMakenWijzigen.Enabled = false;
            }
        }

        //code om github repository te openen
        private void linklabelGithubRepository_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DaanHautekeete/Opdracht-SOFO-Arrays---Klassen---Objecten");
        }

        //code om een bestaand contactpersoon te selecteren
        private void lsbContactpersonen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listbox leegmaken
            lsbBasisinfoContactpersonen.Items.Clear();

            //index van geselecteerd contactpersoon veranderen
            intIndexGeselecteerdContactpersoon = lsbContactpersonen.SelectedIndex;

            if(lsbContactpersonen.SelectedIndex != -1)
            {
                Contactpersoon GeselecteerdContactpersoon = (Contactpersoon)arrContacten[intIndexGeselecteerdContactpersoon, 0];

                //preview aanpassen
                lsbBasisinfoContactpersonen.Items.Add("Naam: " + GeselecteerdContactpersoon.Naam + " " + GeselecteerdContactpersoon.Voornaam);
                lsbBasisinfoContactpersonen.Items.Add("Email: " + GeselecteerdContactpersoon.Emailadres);
                lsbBasisinfoContactpersonen.Items.Add("Telefoonnummer: " + GeselecteerdContactpersoon.Telefoonnummer);

                //knop wijzigen en lezen
                btnBekijk.Enabled = true;
                btnWijzigContactpersoon.Enabled = true;
            }
            else
            {
                MessageBox.Show("Kies een geldig contactpersoon", "Ongeldige keuze", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //radiobuttons om keuze appartement te maken
        private void rdbMeerdereBussenTrue_CheckedChanged(object sender, EventArgs e)
        {
            //textbox van bus inschakelen
            txtBus.Enabled = true;
        }

        private void rdbMeerdereBussenFalse_CheckedChanged(object sender, EventArgs e)
        {
            txtBus.Enabled = false;
        }

        //knop om programma af te sluiten
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dlgKeuze = MessageBox.Show("Bent u zeker dat u het programma wilt afsluiten?\nDit resulteert in het verliezen in alle gegevens!", "Programma sluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlgKeuze == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Eigen functies
        ///|/////////////////////////////////////////////////////////////////////////////////////
        private void InvoerResetten()
        {
            //alle invoer resetten
            //algemene info
            txtNaam.Clear();
            txtVoornaam.Clear();
            txtTelefoonnummer.Clear();
            txtEmailadres.Clear();

            //adres
            txtStraatnaam.Clear();
            txtHuisnummer.Clear();
            rdbMeerdereBussenFalse.Checked = true;
            //rdbMeerdereBussenTrue.Checked = false;
            txtBus.Clear();
            txtBus.Enabled = false;
            txtLand.Clear();
            txtStad.Clear();
        }


    }
}