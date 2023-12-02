using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3MaycolMuñoz.clases
{
    internal class ColaEPS
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public byte Edad { get; set; }
        public string TipoConsulta { get; set; }
        public int TiempoEspera { get; set; }
        public DateTime Fecha { get; set; }

        public ColaEPS(string identificacion, string nombre, byte edad, string tipoConsulta, int tiempoEspera, DateTime fecha)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Edad = edad;
            TipoConsulta = tipoConsulta;
            TiempoEspera = tiempoEspera;
            Fecha = fecha;
        }

    }
}
