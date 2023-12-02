using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3MaycolMuñoz.clases
{
    internal class ListaJardin
    {
        public string NumRCivil { get; set; }
        public string Nombre { get; set; }
        public string Condicion { get; set; }
        public byte Estrato { get; set; }
        public bool Terapia { get; set; }
        public DateTime FechaNac { get; set; }

        public ListaJardin(string numRCivil, string nombre, string condicion, byte estrato, bool terapia, DateTime fechaNac)
        {
            NumRCivil = numRCivil;
            Nombre = nombre;
            Condicion = condicion;
            Estrato = estrato;
            Terapia = terapia;
            FechaNac = fechaNac;
        }

    }
}
