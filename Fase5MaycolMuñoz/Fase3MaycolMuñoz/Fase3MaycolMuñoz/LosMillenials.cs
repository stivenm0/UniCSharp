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
    public partial class LosMillenials : Form
    {
        private List<ListaJardin> Registros;
        private int puntero = -1;

        public LosMillenials()
        {
            Registros = new List<ListaJardin>();
            InitializeComponent();
        }

        //guardar
        private void guardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                string RC = txtId.Text;
                string nombre = txtNombre.Text;
                DateTime Fnacimiento = CFecha.Value;
                string condicion = CCondicion.Text;
                byte estrato = Convert.ToByte(CEstrato.Text);
                bool terapia = CTerapia.Text == "sí"? true : false;

                Registros.Add(new ListaJardin(RC, nombre, condicion, estrato, terapia, Fnacimiento));

                dataGridView1.DataSource = Registros.ToArray();

                this.limpiar();
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
            if (CEstrato.Text ==  "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CEstrato, "Campo Vacío");
                return false;
            }
            if (CCondicion.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CCondicion, "Campo Vacío");
                return false;
            }
            if (CTerapia.Text == "")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(CTerapia, "Campo Vacío");
                return false;
            }

            errorProvider1.Clear();
            return true;
        }


        //Consultar
        private void consutar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Trim() == "")
            {
                errorProvider1.SetError(txtId, "Campo Requerido Para Consultar");
            }
            else
            {
                errorProvider1.Clear();
                foreach (ListaJardin registro in Registros)
                {
                    if (registro.NumRCivil == txtId.Text)
                    {
                        puntero = Registros.IndexOf(registro);
                        txtNombre.Text = registro.Nombre;
                        CFecha.Value = registro.FechaNac;
                        CEstrato.Text = registro.Estrato.ToString();
                        CCondicion.Text = registro.Condicion;
                        CTerapia.Text = registro.Terapia ? "sí": "no";
                        eliminar.Enabled = true;
                        break; 
                    }
                }

            }
        }

        //limpiar
        private void limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            CFecha.Value = DateTime.Today;
            CCondicion.SelectedItem = null;
            CEstrato.SelectedItem = null;
            CTerapia.SelectedItem = null;
        }

        //eliminar
        private void eliminar_Click(object sender, EventArgs e)
        {
            if(puntero >= 0)
            {
                Registros.RemoveAt(puntero);
                puntero = -1;


                dataGridView1.DataSource = Registros.ToArray();

                this.limpiar();
                eliminar.Enabled = false;
            }
            
        }

        //salir
        private void regresar_Click(object sender, EventArgs e)
        {
            MenuOpciones mn = new MenuOpciones();
            mn.Show();
            this.Close();
        }
    }
}
