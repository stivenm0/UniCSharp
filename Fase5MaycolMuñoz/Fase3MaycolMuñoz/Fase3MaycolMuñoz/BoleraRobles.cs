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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fase3MaycolMuñoz
{
    public partial class BoleraRobles : Form
    {
        private PilaBolos reserva;
        private double Acumulado = 0;

        private Stack<PilaBolos> Reservas;
        public BoleraRobles()
        {
            Reservas = new Stack<PilaBolos>();
            InitializeComponent();
            CPista.DropDownStyle = ComboBoxStyle.DropDownList;
            CJugadores.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //Calcular Precio
        private void button1_Click(object sender, EventArgs e)
        {       
            if (this.ValidarCampos())
            {
                string id = txtId.Text;
                string nombre = txtNombre.Text;
                string direccion = txtDireccion.Text;
                byte pista = Convert.ToByte(CPista.Text);
                byte jugadores = Convert.ToByte(CJugadores.Text);
                bool afiliado = CAfiliado.Text == "sí" ? true : false;
                DateTime fecha = CFecha.Value;

                double precio = 50000 + Util.Bolera["jugadores"][jugadores] + Util.Bolera["pista"][pista];
                precio -= afiliado ? 50000 * 0.1 : 0;

                txtPrecio.Text = precio.ToString();
                reserva = new PilaBolos(id, nombre, direccion, jugadores, pista, afiliado, precio, fecha);
                guardar.Enabled = true;
            }
        }

        //Guardar
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (this.ValidarCampos())
            {
                Reservas.Push(reserva);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Reservas.ToArray();

                Acumulado += Convert.ToDouble(txtPrecio.Text);

                //limpiar
                txtId.Text = "";
                txtNombre.Text = "";
                txtDireccion.Text = "";
                CPista.SelectedItem = null; ;
                CJugadores.SelectedItem = null; ;
                CAfiliado.SelectedItem = null; ;
                CFecha.Value = DateTime.Today;
                txtPrecio.Text = "50000";
                guardar.Enabled = false;
            }
        }

        //validación
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
            if (txtDireccion.Text.Trim() == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(txtDireccion, "Campo Vacío");
                return false;
            }
            if (CPista.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CPista, "Campo Vacío");
                return false;
            }
            if (CJugadores.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CJugadores, "Campo Vacío");
                return false;
            }
            if (CAfiliado.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CAfiliado, "Campo Vacío");
                return false;
            }

            if (!(CFecha.Value >= DateTime.Today))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CFecha, "Campo Erroneo");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }

        //salir
        private void regresar_Click(object sender, EventArgs e)
        {
            MenuOpciones mn = new MenuOpciones();
            mn.Show();
            this.Hide();
        }

        //eliminar
        private void eliminar_Click(object sender, EventArgs e)
        {
            if (Reservas.Count != 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar la reserva de " + reserva.Nombre + "?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Acumulado = Reservas.Count == 0 ? 0 : Acumulado - reserva.Precio;

                    Reservas.Pop();
                    reserva = Reservas.Count == 0? null : Reservas.Peek();
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Reservas.ToArray();
                }
            }
        }


        //Acumulado
        private void btnAcumulado_Click(object sender, EventArgs e)
        {
            string mensaje = "El acumulado es: "+ Acumulado;
            string titulo = "Total Acumulado";

            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    
    }
}
