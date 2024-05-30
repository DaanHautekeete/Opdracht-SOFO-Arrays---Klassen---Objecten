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

        const int cintStandaardbreedteIngeklapt = 593;
        const int cintStandaardBreedteUitgeklapt = 1094;
        const int cintStandaardHoogte = 819;

        //var aanmaken voor aantal personen in array
        int intIndexContactpersoon = 0;
        
        //var voor index geselecteerd contactpersoon
        int intIndexGeselecteerdContactpersoon;

        //bool voor save
        bool isNew = true;

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

            //form resizen
            this.Size = new Size(cintStandaardbreedteIngeklapt, cintStandaardHoogte);
        }

        ///|/////////////////////////////////////////////////////////////////////////////////////
        //|Alle knoppen en listboxen
        ///|/////////////////////////////////////////////////////////////////////////////////////

        private void btnNieuwContactpersoon_Click(object sender, EventArgs e)
        {
            //form resizen
            this.Size = new Size(cintStandaardBreedteUitgeklapt, cintStandaardHoogte);

            //alles resetten van invoer
            InvoerResetten();

            //groupbox unlocken
            grpbMakenWijzigen.Enabled = true;
            grpbMakenWijzigen.Text = "Nieuw contactpersoon";

            //standaardwaarde meegeven voor keuze appartement
            rdbMeerdereBussenFalse.Checked = true;

            //new contact true
            isNew = true;

            //focus op eerste textbox
            txtNaam.Focus();
        }

        private void btnWijzigContactpersoon_Click(object sender, EventArgs e)
        {
            //form resizen
            this.Size = new Size(cintStandaardBreedteUitgeklapt, cintStandaardHoogte);

            //tijdelijk object aan maken
            Contactpersoon contactpersoonWijzigen = (Contactpersoon)arrContacten[lsbContactpersonen.SelectedIndex, 0];

            //titel van groupbox wijzigen
            grpbMakenWijzigen.Text = contactpersoonWijzigen.VolledigeNaam.ToString() + " aan het wijzigen";

            //alle attributen inladen
            InformatieContactpersoonInladen();

            //grb unlocken om aanpassingen te aanvaarden
            grpbMakenWijzigen.Enabled = true;

            //geen nieuw contactpersoon
            isNew = false;
        }

        private void btnBekijk_Click(object sender, EventArgs e)
        {
            //form resizen
            this.Size = new Size(cintStandaardBreedteUitgeklapt, cintStandaardHoogte);

            //eigen fucntie gebruiken om informatie te tonen
            InformatieContactpersoonInladen();

        }

        private void btnVerwijderContactpersoon_Click(object sender, EventArgs e)
        {
            //alle invoer legen
            InvoerResetten();

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

            //form resizen
            this.Size = new Size(cintStandaardbreedteIngeklapt, cintStandaardHoogte);
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
                if(txtStad.Text.Trim() != string.Empty)
                {
                    contactpersoon.Stad = txtStad.Text;
                }

                //kijken of er een nieuw contact wordt aangemaakt of als er één gewijzigd wordt
                if (isNew)
                {
                    arrContacten[intIndexContactpersoon, 0] = contactpersoon;

                    // Voeg de naam van de contactpersoon toe aan de listbox
                    lsbContactpersonen.Items.Add(contactpersoon.VolledigeNaam.ToString());

                    // Verhoog de index voor de volgende contactpersoon
                    intIndexContactpersoon++;

                }
                else {
                    //origineel object overschijven
                    arrContacten[lsbContactpersonen.SelectedIndex, 0] = contactpersoon;

                    //listbox items aanpassen om mogelijke aanpssing in naam of voornaam weer te geven
                    lsbContactpersonen.Items.Clear();
                    for (int i = 0; i < arrContacten.GetUpperBound(0); i++)
                    {
                        //tijdelijk object dat automatisch wijzigt
                        Contactpersoon namenVoorContactpersoon = (Contactpersoon)arrContacten[i, 0];

                        //controleren als object leeg is
                        if (namenVoorContactpersoon != null)
                        {
                            //als object niet leeg is => volledige naam toevoegen aan listbox van contactpersonen
                            lsbContactpersonen.Items.Add(namenVoorContactpersoon.VolledigeNaam.ToString());
                        }
                        else
                        {
                            //als het object leeg is => vroegtijdig loop verlaten
                            break;
                        }
                    }

                    //algemene info resetten
                    lsbBasisinfoContactpersonen.Items.Clear();
                }
                    //alle invoer verwijderen en groupbox vergrendelen
                    InvoerResetten();

                    //knop voor alle contactpersonen te wissen, inschakelen
                    btnVerwijderContactpersoon.Enabled = true;

                    //properties van groupbox wijzigen
                    grpbMakenWijzigen.Text = "Nieuw/wijzig/lees contactpersoon";
                    grpbMakenWijzigen.Enabled = false;

                //form resizen
                this.Size = new Size(cintStandaardbreedteIngeklapt, cintStandaardHoogte);
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
            DialogResult dlgKeuze = MessageBox.Show("Bent u zeker dat u het programma wilt afsluiten?\nDit resulteert in het verliezen van alle gegevens!", "Programma sluiten", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            txtBus.Clear();
            txtBus.Enabled = false;
            txtLand.Clear();
            txtStad.Clear();
        }

        private void InformatieContactpersoonInladen()
        {
            //object maken van contactpersoon in de array
            Contactpersoon tijdelijkContactpersoon = (Contactpersoon)arrContacten[lsbContactpersonen.SelectedIndex, 0];

            //alle eigenschappen weergeven

            //algemene info
            txtNaam.Text = tijdelijkContactpersoon.Naam;
            txtVoornaam.Text = tijdelijkContactpersoon.Voornaam;
            txtTelefoonnummer.Text = tijdelijkContactpersoon.Telefoonnummer;
            txtEmailadres.Text = tijdelijkContactpersoon.Emailadres;

            //adres
            txtStraatnaam.Text = tijdelijkContactpersoon.Straatnaam;
            txtHuisnummer.Text = tijdelijkContactpersoon.Huisnummer;
            if(tijdelijkContactpersoon.Appartement == true)
            {
                rdbMeerdereBussenTrue.Checked = true;
            }
            else
            {
                rdbMeerdereBussenFalse.Checked = true;
            }
            txtBus.Text = tijdelijkContactpersoon.Bus;
            txtLand.Text = tijdelijkContactpersoon.Land;
            txtStad.Text = tijdelijkContactpersoon.Stad;
            
        }

    }
}