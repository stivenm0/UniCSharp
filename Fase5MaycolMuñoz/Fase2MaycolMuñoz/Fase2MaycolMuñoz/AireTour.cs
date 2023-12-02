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
    public partial class AireTour : Form
    {
        Vuelo vuelo;
        private string Dx = "Valor Incorrecto";
        private string Dv = "Ingrese un Valor";
        private string[] Generos = { "Masculino", "Femenino", "otro" };
        private string[] Estratos = { "1", "2", "3", "4", "5", "6" };
        private string[] Dias = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
        private string[] ClasesVuelo = { "A", "B", "C" };
        private string[] Destinos = { "Bogotá", "Medellín", "Florencia", "Pitalito" };

        public AireTour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                string idV = id.Text;
                string nombreV = nombre.Text;
                string generoV = genero.Text;
                string estratoV = estrato.Text;
                string destinoV = destino.Text;
                string claseV = clase.Text;
                string diaV = dia.Text;
                double precioV = Data.Precios[claseV][destinoV];

                precio.Text = precioV.ToString();
                vuelo = new Vuelo(idV, nombreV, generoV, estratoV, destinoV, claseV, diaV, precioV);

                btnCalcular.Enabled = true;
            }

        }


        



        private bool ValidarCampos()
        {
            if (id.Text.Trim() == "" )
            {
                errorP.Clear();
                errorP.SetError(id, Dv);
                return true;
            }
            if(nombre.Text.Trim() == "")
            {
                errorP.Clear();
                errorP.SetError(nombre, Dv);
                return true;
            }
            if (!Estratos.Contains(estrato.Text))
            {
                errorP.Clear();
                errorP.SetError(estrato, Dx);
                return true;
            }
            if (!Dias.Contains(dia.Text))
            {
                errorP.Clear();
                errorP.SetError(dia, Dx);
                return true;
            }
            if (!ClasesVuelo.Contains(clase.Text))
            {
                errorP.Clear();
                errorP.SetError(clase, Dx);
                return true;
            }
            if (!Destinos.Contains(destino.Text))
            {
                errorP.Clear();
                errorP.SetError(destino, Dx);
                return true;
            }
            if (!Generos.Contains(genero.Text))
            {
                errorP.Clear();
                errorP.SetError(genero, Dx);
                return true;
            }

            return false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vuelo.calcularDescuento();
            Reporte R = new Reporte(vuelo);
            this.Close();
            R.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas cerrar el sistema?", "Confirmar Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
