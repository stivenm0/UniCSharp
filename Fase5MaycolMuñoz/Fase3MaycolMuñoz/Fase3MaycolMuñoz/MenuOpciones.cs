using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase3MaycolMuñoz
{
    public partial class MenuOpciones : Form
    {
        public MenuOpciones()
        {
            InitializeComponent();
        }


        //Form Pila
        private void button1_Click(object sender, EventArgs e)
        {
            BoleraRobles BR = new BoleraRobles();
            BR.Show();
            this.Close();
        }


        //Form Cola
        private void button2_Click(object sender, EventArgs e)
        {
            SanarteYa SY = new SanarteYa();
            SY.Show();
            this.Close();
        }


        //Form Lista
        private void button3_Click(object sender, EventArgs e)
        {
            LosMillenials LM = new LosMillenials();
            LM.Show();
            this.Close();
        }


        //Cerrar Programa
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
