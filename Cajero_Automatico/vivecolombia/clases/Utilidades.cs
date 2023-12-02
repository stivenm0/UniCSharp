using System;

public static class Utilidades
{
    private static string rutaArchivo = "../../../DB.txt";
    private static string[] lineas; //array de las líneas DB
    private static string[,] datos; //array de los datos DB
    private static int puntero; //puntero de cliente en array datos
    private static int p2; //puntero de cliente destinatario transferencia

    //Inicializa los arrays con datos de DB
    public static void exe()
	{
        // Leer los datos desde el archivo
        lineas = File.ReadAllLines(rutaArchivo);

        // Organizar los datos en un formato de arreglo
        datos = new string[lineas.Length - 1, lineas[0].Split(',').Length];

        // Recorrer las líneas y acomodar los datos en el arreglo
        for (int i = 1; i < lineas.Length; i++)
        {
            string[] campos = lineas[i].Split(',');

            for (int j = 0; j < campos.Length; j++)
            {
                datos[i - 1, j] = campos[j];
            }
        }
    }

    public static Cliente obtenerCliente(string cc, string clave = null)
    {
        //Si encuentra coincidencia devuelve el cliente de lo contrario devuelve null
        Cliente cliente= null;
        for (int i = 0; i<lineas.Length-1; i++)
        {
            if (cc == datos[i, 0]) { 
                if(clave == datos[i, 1] || clave == null)
                {
                    if(clave == null)
                    {
                        p2 = i;
                        clave = datos[i, 1];
                    }
                    else{  puntero = i; }

                    string nombre = datos[i, 2];
                    string edad = datos[i, 3];
                    int puntos = Convert.ToInt32(datos[i, 4]);
                    double saldo = Double.Parse(datos[i, 5]);
                    double dineroRetirado = Double.Parse(datos[i, 6]);
                    DateTime fechaRetiro = DateTime.Parse(datos[i, 7]);

                    cliente = new Cliente(cc, clave, nombre, edad, puntos, saldo, dineroRetirado, fechaRetiro);

                    return cliente;
                }
            }
        }
        return cliente;
    }

    public static void actualizarCliente(Cliente cliente, bool externo = false)
    {
        //actualiza datos, convierte la fila en línea, actualiza líneas y actualiza DB
        int id = externo ? p2 : puntero;
        datos[id, 4] = Convert.ToString( cliente.Puntos );
        datos[id, 5] = cliente.Saldo.ToString().Replace(",", ".");
        datos[id, 6] = cliente.DineroRetirado.ToString().Replace(",", ".");
        datos[id, 7] = cliente.FechaRetiro.ToString();

        string linea = string.Join(",", Enumerable.Range(0, datos.GetLength(1)).Select(columna => datos[id, columna]));

        lineas[id+1] = linea;
        File.WriteAllLines(rutaArchivo, lineas);
    }




}



