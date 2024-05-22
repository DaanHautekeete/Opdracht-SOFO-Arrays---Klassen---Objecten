using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSofoTaakKlassesEnObjecten
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            //code om knoppen te laten veranderen van kleur bij hover
            btnNieuwContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnWijzigContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnVerwijderContactpersoon.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.Gray;
        }
    }
}
