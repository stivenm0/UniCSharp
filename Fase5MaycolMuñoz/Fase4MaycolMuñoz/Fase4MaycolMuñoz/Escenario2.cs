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
    public partial class Escenario2 : Form
    {
        public Escenario2()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu mn = new Menu();
            mn.Show();
        }

        private void Escenario2_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void gráficaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics lienzo = CreateGraphics();
            Pen pen = new Pen(Color.Black, 1); // Define un lápiz para el borde

            lienzo.DrawLine(pen, 225, 55, 114, 100);
            lienzo.DrawLine(pen, 225, 55, 400, 90);//50

            lienzo.DrawLine(pen, 130, 90, 110, 140);
            lienzo.DrawLine(pen, 130, 95, 220, 145);//17

            lienzo.DrawLine(pen, 105, 165, 80, 200);
            lienzo.DrawLine(pen, 110, 165, 130, 200);//12

            lienzo.DrawLine(pen, 405, 103, 332, 152);//72
            lienzo.DrawLine(pen, 405, 103, 474, 152);//72


            lienzo.DrawLine(pen, 225, 160, 200, 200);//15

            lienzo.DrawLine(pen, 328, 155, 390, 203);//54


            lienzo.FillEllipse(Brushes.Cyan, 220, 40, 35, 35);
            lienzo.DrawEllipse(pen, 220, 40, 35, 35);
            lienzo.DrawString("50", Font, Brushes.Purple, 230, 50);

            //-----------------------------------------------
            lienzo.FillEllipse(Brushes.Cyan, 110, 80, 35, 35);
            lienzo.DrawEllipse(pen, 110, 80, 35, 35);
            lienzo.DrawString("17", Font, Brushes.Purple, 120, 90);

            
            lienzo.FillEllipse(Brushes.Cyan, 210, 140, 35, 35);
            lienzo.DrawEllipse(pen, 210, 140, 35, 35);
            lienzo.DrawString("23", Font, Brushes.Purple, 220, 150);

            lienzo.FillEllipse(Brushes.Cyan, 180, 190, 35, 35);
            lienzo.DrawEllipse(pen, 180, 190, 35, 35);
            lienzo.DrawString("19", Font, Brushes.Purple, 190, 200);
            

            lienzo.FillEllipse(Brushes.Cyan, 90, 140, 35, 35);
            lienzo.DrawEllipse(pen, 90, 140, 35, 35);
            lienzo.DrawString("12", Font, Brushes.Purple, 100, 150);

            lienzo.FillEllipse(Brushes.Cyan, 60, 190, 35, 35);
            lienzo.DrawEllipse(pen, 60, 190, 35, 35);
            lienzo.DrawString("9", Font, Brushes.Purple, 74, 200);

            lienzo.FillEllipse(Brushes.Cyan, 120, 190, 35, 35);
            lienzo.DrawEllipse(pen, 120, 190, 35, 35);
            lienzo.DrawString("14", Font, Brushes.Purple, 130, 200);

            //-------------------------------------------------
            
            lienzo.FillEllipse(Brushes.Cyan, 390, 82, 35, 35);
            lienzo.DrawEllipse(pen, 390, 82, 35, 35);
            lienzo.DrawString("72", Font, Brushes.Purple, 400, 92);

            lienzo.FillEllipse(Brushes.Cyan, 310, 140, 35, 35);
            lienzo.DrawEllipse(pen, 310, 140, 35, 35);
            lienzo.DrawString("54", Font, Brushes.Purple, 320, 150);

            lienzo.FillEllipse(Brushes.Cyan, 380, 190, 35, 35);
            lienzo.DrawEllipse(pen, 380, 190, 35, 35);
            lienzo.DrawString("67", Font, Brushes.Purple, 390, 200);


            lienzo.FillEllipse(Brushes.Cyan, 460, 140, 35, 35);
            lienzo.DrawEllipse(pen, 460, 140, 35, 35);
            lienzo.DrawString("76", Font, Brushes.Purple, 470, 150);
          
        }

        private void preordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            preorden.Visible = true;
        }

        private void inordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inorden.Visible = true;
        }

        private void posordenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            postorden.Visible = true;
        }

    }
}
