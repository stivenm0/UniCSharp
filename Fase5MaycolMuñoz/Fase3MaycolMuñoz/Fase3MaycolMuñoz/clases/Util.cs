using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3MaycolMuñoz.clases
{
    internal static class Util
    {
        public static Dictionary<string, Dictionary<byte, double>> Bolera = new Dictionary<string, Dictionary<byte, double>>
        {
            {
                "jugadores", new Dictionary<byte, double>
                {
                    { 1, 0 },
                    { 2, 1000 },
                    { 3, 2000 },
                    { 4, 3000 },
                    { 5, 4000 },
                    { 6, 5000 }
                   
                }
            },
            {
                 "pista", new Dictionary<byte, double>
                {
                    { 1, 0 },
                    { 2, 0 },
                    { 3, 5000 },
                    { 4, 10000 },
                }
            },

        };

    }
}
