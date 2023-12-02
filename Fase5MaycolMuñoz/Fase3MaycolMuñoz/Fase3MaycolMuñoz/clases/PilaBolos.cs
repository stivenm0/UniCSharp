using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3MaycolMuñoz
{
    internal class PilaBolos
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public byte CantJugadores { get; set; }
        public byte NumPista { get; set; }
        public bool Afiliado { get; set; }
        public double Precio { get; set; }
        public DateTime Fecha { get; set; }

        public PilaBolos(string identificacion, string nombre, string direccion, byte cantJugadores, byte numPista, bool afiliado, double precio, DateTime fecha)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            CantJugadores = cantJugadores;
            NumPista = numPista;
            Afiliado = afiliado;
            Precio = precio;
            Fecha = fecha;
        }






    }
}
