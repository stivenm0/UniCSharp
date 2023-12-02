using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase4MaycolMuñoz
{
    public partial class Escenario1 : Form
    {

        public Escenario1()
        {
            InitializeComponent();

        }

        private void recorridoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void gráficaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Graphics lienzo = CreateGraphics();
            Pen pen = new Pen(Color.Black, 1); // Define un lápiz para el borde

            lienzo.DrawLine(pen, 225, 55, 114, 100);
            lienzo.DrawLine(pen, 225, 55, 400, 90);//70

            lienzo.DrawLine(pen, 130, 90, 80, 250);
            lienzo.DrawLine(pen, 130, 95, 180, 140);//20

            lienzo.DrawLine(pen, 180, 160, 158, 203);
            lienzo.DrawLine(pen, 192, 160, 225, 203);//59

            lienzo.DrawLine(pen, 405, 103, 332, 152);//98

            lienzo.DrawLine(pen, 328, 155, 294, 203);
            lienzo.DrawLine(pen, 328, 155, 390, 203);//77

            lienzo.DrawLine(pen, 390, 210, 340, 250);//78

            lienzo.DrawLine(pen, 340, 260, 360, 300);//86

            lienzo.FillEllipse(Brushes.Cyan, 220, 40, 35, 35);
            lienzo.DrawEllipse(pen, 220, 40, 35, 35);
            lienzo.DrawString("70", Font, Brushes.Purple, 230, 50);

            //-----------------------------------------------
            lienzo.FillEllipse(Brushes.Cyan, 110, 80, 35, 35);
            lienzo.DrawEllipse(pen, 110, 80, 35, 35);
            lienzo.DrawString("20", Font, Brushes.Purple, 120, 90);

            lienzo.FillEllipse(Brushes.Cyan, 92, 140, 35, 35);
            lienzo.DrawEllipse(pen, 92, 140, 35, 35);
            lienzo.DrawString("15", Font, Brushes.Purple, 100, 150);

            lienzo.FillEllipse(Brushes.Cyan, 78, 190, 35, 35);
            lienzo.DrawEllipse(pen, 78, 190, 35, 35);
            lienzo.DrawString("10", Font, Brushes.Purple, 86, 200);

            lienzo.FillEllipse(Brushes.Cyan, 65, 239, 35, 35);
            lienzo.DrawEllipse(pen, 65, 239, 35, 35);
            lienzo.DrawString("2", Font, Brushes.Purple, 78, 249);

            lienzo.FillEllipse(Brushes.Cyan, 170, 140, 35, 35);
            lienzo.DrawEllipse(pen, 170, 140, 35, 35);
            lienzo.DrawString("59", Font, Brushes.Purple, 180, 150);

            lienzo.FillEllipse(Brushes.Cyan, 140, 190, 35, 35);
            lienzo.DrawEllipse(pen, 140, 190, 35, 35);
            lienzo.DrawString("29", Font, Brushes.Purple, 150, 200);

            lienzo.FillEllipse(Brushes.Cyan, 210, 190, 35, 35);
            lienzo.DrawEllipse(pen, 210, 190, 35, 35);
            lienzo.DrawString("69", Font, Brushes.Purple, 220, 200);

            //-------------------------------------------------
            lienzo.FillEllipse(Brushes.Cyan, 390, 82, 35, 35);
            lienzo.DrawEllipse(pen, 390, 82, 35, 35);
            lienzo.DrawString("98", Font, Brushes.Purple, 400, 92);

            lienzo.FillEllipse(Brushes.Cyan, 310, 140, 35, 35);
            lienzo.DrawEllipse(pen, 310, 140, 35, 35);
            lienzo.DrawString("77", Font, Brushes.Purple, 320, 150);

            lienzo.FillEllipse(Brushes.Cyan, 275, 190, 35, 35);
            lienzo.DrawEllipse(pen, 275, 190, 35, 35);
            lienzo.DrawString("75", Font, Brushes.Purple, 285, 200);

            lienzo.FillEllipse(Brushes.Cyan, 380, 190, 35, 35);
            lienzo.DrawEllipse(pen, 380, 190, 35, 35);
            lienzo.DrawString("91", Font, Brushes.Purple, 390, 203);

            lienzo.FillEllipse(Brushes.Cyan, 320, 239, 35, 35);
            lienzo.DrawEllipse(pen, 320, 239, 35, 35);
            lienzo.DrawString("78", Font, Brushes.Purple, 330, 249);

            lienzo.FillEllipse(Brushes.Cyan, 345, 290, 35, 35);
            lienzo.DrawEllipse(pen, 345, 290, 35, 35);
            lienzo.DrawString("86", Font, Brushes.Purple, 355, 300);

        }

        private void regresarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu mn = new Menu();
            mn.Show();
        }

        private void Escenario1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
