using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSofoTaakKlassesEnObjecten {
    public partial class frmEditOrNew : Form {



        public frmEditOrNew() {
            InitializeComponent();
            frmMenu frmMenu = new frmMenu();
            this.Text = frmMenu.nieuwContactAanmakenTitel;

            //radiobuttons van bus automatisch op neen zetten
            rdbNeen.Checked = true;
            rdbJa.Checked = false;

            //textbox van bus automatisch uitschakelen bij opstarten
            txtBus.Enabled = false;

            //code om knoppen van kleur te laten veranderen
            btnNew.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnVerwijder.FlatAppearance.MouseOverBackColor = Color.Gray;
        }

        private void picProfilePicture_Click(object sender, EventArgs e)
        {
            //filedialog openen om foto te kiezen
            
        }

        private void rdbJa_CheckedChanged(object sender, EventArgs e)
        {
            //textbox van bus inschakelen
            txtBus.Enabled = true;
        }

        private void rdbNeen_CheckedChanged(object sender, EventArgs e)
        {
            //textbox bus uitschakelen
            txtBus.Enabled = false;
            txtBus.Text = string.Empty;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddCustomProperties frmAddCustomProperties = new frmAddCustomProperties();

            frmAddCustomProperties.Show();
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
                frmMenu.contacten[frmMenu.intIndexContactpersoon,0] = contactpersoon;

                frmMenu.reloadLsb();

                //index van contactpersoon + 1
                frmMenu.intIndexContactpersoon++;
            }
        }
    }
}
