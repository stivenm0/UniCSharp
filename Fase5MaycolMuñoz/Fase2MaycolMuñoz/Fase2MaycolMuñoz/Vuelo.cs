using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2MaycolMuñoz
{
    public class Vuelo
    {

        public string identificacion;
        public string nombre;
        public string genero;
        public string estrato;
        public string destino;
        public string clase;
        public string diaSemana;
        public double precio;
        public double descuento;


        public Vuelo(string identificacion, string nombre, string genero, string estrato, string destino, string clase, string diaSemana, double precio )
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.genero = genero;
            this.destino = destino;
            this.estrato = estrato;
            this.clase = clase;
            this.diaSemana = diaSemana;
            this.precio= precio;
        }

        public void calcularDescuento()
        {
            descuento = precio * Data.Desuentos["Estrato"][estrato] 
                + precio * Data.Desuentos["Dia"][diaSemana];

            if( genero == "Femenino" ) {
                descuento += precio * 0.03;
            }
        }










    }
}
