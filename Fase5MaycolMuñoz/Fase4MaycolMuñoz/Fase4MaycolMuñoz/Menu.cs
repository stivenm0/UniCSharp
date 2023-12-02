using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4MaycolMuñoz
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void scn1_Click(object sender, EventArgs e)
        {
            Escenario1 scn1 = new Escenario1();
            scn1.Show();
            this.Close();
        }

        private void scn2_Click(object sender, EventArgs e)
        {
            Escenario2 scn2 = new Escenario2();
            scn2.Show();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmar cierre", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
