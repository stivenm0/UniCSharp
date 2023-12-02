using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase2MaycolMuñoz
{
    internal static class Data
    {

        public static Dictionary<string, Dictionary<string, double>> Precios = new Dictionary<string, Dictionary<string, double>>
        {
            {
                "A", new Dictionary<string, double>
                {
                    { "Bogotá", 300000 },
                    { "Medellín", 420000 },
                    { "Florencia", 270000 },
                    { "Pitalito", 250000 }
                }
            },
            {
                 "B", new Dictionary<string, double>
                {
                    { "Bogotá", 225000 },
                    { "Medellín", 315000 },
                    { "Florencia", 202500 },
                    { "Pitalito", 187500 }
                }
            },
            {
                 "C", new Dictionary<string, double>
                {
                    { "Bogotá", 150000 },
                    { "Medellín", 210000 },
                    { "Florencia", 135000 },
                    { "Pitalito", 125000 }
                }
            }

        };


        public static Dictionary<string, Dictionary<string, double>> Desuentos = new Dictionary<string, Dictionary<string, double>> 
        {
            {
                "Estrato", new Dictionary<string, double>
                {
                    {"1", 0.10 },
                    {"2", 0.10 },
                    {"3", 0.07 },
                    {"4", 0.07 },
                    {"5", 0.05 },
                    {"6", 0.05 }
                }
            },
            {
                "Dia", new Dictionary<string, double>
                {
                    {"Lunes", 0.10 },
                    {"Martes", 0.10 },
                    {"Miércoles", 0.10 },
                    {"Jueves", 0.05 },
                    {"Viernes", 0.05 },
                    {"Sábado", 0.0 },
                    {"Domingo", 0.0 }
                }
            }
        
        };



    }
}
