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
    public partial class frmAddCustomProperties : Form
    {
        public frmAddCustomProperties()
        {
            InitializeComponent();

            //code toevoegen om knoppen van kleur te veranderen
            btnAssign.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnNew.FlatAppearance.MouseOverBackColor = Color.Gray;
        }
    }
}
