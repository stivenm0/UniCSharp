using Fase3MaycolMuñoz.clases;
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
    public partial class SanarteYa : Form
    {

        private Queue<ColaEPS> Registros;
        private ColaEPS registro;
        public SanarteYa()
        {
            Registros = new Queue<ColaEPS>();
            InitializeComponent();
        }

        private void CalTiempo_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string id = txtId.Text;
                string nombre = txtNombre.Text;
                byte edad = Convert.ToByte(txtEdad.Text);
                string Tconsulta = CConsulta.Text;
                DateTime fecha = CFecha.Value;
                int tiempoEspera = 0;

                if (Tconsulta == "prioritaria")
                {
                    if (edad >= 0 && edad <= 10) { tiempoEspera = 10; }

                    else if (edad >= 11 && edad <= 20 || edad >= 41 && edad <= 60) { tiempoEspera = 20; }

                    else if (edad >= 21 && edad <= 40) { tiempoEspera = 25; }

                    else if (edad > 60) { tiempoEspera = 5; }
                }
                else if (Tconsulta == "general")
                {
                    if (edad >= 0 && edad <= 10) { tiempoEspera = 20; }

                    else if (edad >= 11 && edad <= 20 || edad >= 41 && edad <= 60) { tiempoEspera = 30; }

                    else if (edad >= 21 && edad <= 40) { tiempoEspera = 35; }

                    else if (edad > 60) { tiempoEspera = 10; }
                }
                else if (Tconsulta == "urgencia")
                {
                    if (edad >= 0 && edad <= 10) { tiempoEspera = 5; }

                    else if (edad >= 11 && edad <= 20 || edad >= 41 && edad <= 60) { tiempoEspera = 10; }

                    else if (edad >= 21 && edad <= 40) { tiempoEspera = 15; }

                    else if (edad > 60) { tiempoEspera = 0; }
                }

                txtTiempo.Text = tiempoEspera.ToString();
                registro = new ColaEPS(id, nombre, edad, Tconsulta, tiempoEspera, fecha);
                guardar.Enabled = true;
            }
        }

        //Guardar
        private void guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Registros.Enqueue(registro);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Registros.ToArray();
                //limpiar
                txtId.Text = "";
                txtNombre.Text = "";
                txtEdad.Text = "";
                CConsulta.SelectedItem = null;
                CFecha.Value = DateTime.Today;
                txtTiempo.Text = "00000";
                guardar.Enabled = false;
            }
        }

        //Validar
        private bool ValidarCampos()
        {
            if (txtId.Text.Trim() == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtId, "Campo Vacío");
                return false;
            }
            if (txtNombre.Text.Trim() == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtNombre, "Campo Vacío");
                return false;
            }
            try
            {
                if (txtEdad.Text.Trim() == "")
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtEdad, "Campo Vacío");
                    return false;
                }
                else if (!(Convert.ToInt32(txtEdad.Text) >= 0))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtEdad, "Campo Erroneo");
                    return false;
                }
            }
            catch(Exception ex) {
                errorProvider1.Clear();
                errorProvider1.SetError(txtEdad, "Campo Erroneo");
                return false;
            }
           
            if (CConsulta.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CConsulta, "Campo Vacío");
                return false;
            }
            if(!(CFecha.Value >= DateTime.Today))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CFecha, "Campo Erroneo");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }

        //regresar
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuOpciones mn = new MenuOpciones();
            mn.Show();
        }


        //Total Registros
        private void total_Click(object sender, EventArgs e)
        {
            string mensaje = "Registros: " + Registros.Count;
            string titulo = "Total de Registros";

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //eliminar
        private void eliminar_Click(object sender, EventArgs e)
        {
            if (Registros.Count != 0)
            {
                ColaEPS r = Registros.Peek();
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar el registro de " + r.Nombre + "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Registros.Dequeue();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Registros.ToArray();
                }
            }
        }
    }
}
