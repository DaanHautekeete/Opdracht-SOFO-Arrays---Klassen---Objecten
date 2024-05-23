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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();

            //code toevoegen om knoppen van kleuren te laten veranderen 
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
        }
    }
}
