using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fase2MaycolMuñoz
{
    public partial class Reporte : Form
    {
        public Reporte(Vuelo v)
        {
            InitializeComponent();

            id.Text = v.identificacion;
            nombre.Text = v.nombre;
            genero.Text = v.genero;
            diaVuelo.Text = v.diaSemana;
            destinoClase.Text = v.destino + "(" + v.clase + ")";
            estrato.Text = v.estrato;
            operacion.Text = v.precio.ToString() + " - " + v.descuento.ToString(); 
            total.Text = (v.precio - v.descuento).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            AireTour A = new AireTour();
            A.Show();
        }

       
    }
}
