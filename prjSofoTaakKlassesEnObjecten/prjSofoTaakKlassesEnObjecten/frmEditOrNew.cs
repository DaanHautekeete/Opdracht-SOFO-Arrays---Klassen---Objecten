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
    }
}
