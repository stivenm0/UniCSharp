using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionFinal
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dos_Click(object sender, EventArgs e)
        {
            Fase2MaycolMuñoz.AireTour f2 = new Fase2MaycolMuñoz.AireTour();
            f2.Show();
        }

        private void tres_Click(object sender, EventArgs e)
        {
            Fase3MaycolMuñoz.MenuOpciones f3 = new Fase3MaycolMuñoz.MenuOpciones();
            f3.Show();
        }

        private void cuatro_Click(object sender, EventArgs e)
        {
            Fase4MaycolMuñoz.Menu f4 = new Fase4MaycolMuñoz.Menu();
            f4.Show();
        }
    }
}
