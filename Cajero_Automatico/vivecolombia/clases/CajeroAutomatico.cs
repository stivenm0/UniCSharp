using System;

public class CajeroAutomatico
{
    private string info = "¡EN CASO DE INGRESAR VALORES INCORRECTOS SE CANCELARA LA OPERACIÓN ENVIÁNDOLO DE REGRESO AL MENÚ!";
    private string barr = @"
|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
";
    private string menu = @"_______________________ Menú Principal ___________________________________
1. Ver Saldo                    - Verifica el saldo disponible en tu cuenta.
2. Ver Puntos ViveColombia      - Consulta la cantidad de puntos acumulados.
3. Canjear Puntos ViveColombia  - Canjea tus puntos en el programa Vive Colombia.
4. Retirar Dinero               - Retira dinero de tu cuenta bancaria.
5. Transferir a otra Cuenta     - Transfiere dinero a otra cuenta del mismo banco.
6. Cerrar Sesión                - Cierra la sesión actual en el cajero.
7. Cerrar Sesión y Salir        - Cierra la sesión y sale del sistema.
____________________________________________________________________________________";
    private bool auth = false; //sesión 
    private Cliente cliente;

    //Inicializa los datos en utilidades
    public CajeroAutomatico() { Utilidades.exe(); }

    //Ejecuta el sistema 
    public void exe()
	{
        while(true)
        {
            if (auth)
            {
                try
                { Menu(); }
                catch (Exception)
                {
                    imprimir("| OPERACIÓN CANCELADA | USTED HA INGRESADO VALORES INCORRECTOS |");
                }
            }
            else
            {
                Console.WriteLine(@"
\/\/\/\/\/ INICIO SESIÓN \/\/\/\/\/");
                autenticacion();
            }

        }

    }

    public void Menu()
    {
        Console.Write(menu);
        int opcion = Convert.ToInt32(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                imprimir("SU SALDO ES: "+  cliente.Saldo);
                break;
            case 2: 
                imprimir("SUS PUNTOS VIVECOLOMBIA SON: "+  cliente.Puntos);
                break;
            case 3:
                canjearPuntos();
                break;
            case 4:
                retirarDinero();
                break;
            case 5:
                transferirDinero();
                break;
            case 6:
                cerrarSesion();
                break;
            case 7:
                cerrarSesion(true);
                break;
            default: 
                imprimir("| OPERACIÓN CANCELADA | USTED HA INGRESADO VALORES INCORRECTOS |");
                break;
        }

    }

    public void imprimir(string info)
    {
        Console.WriteLine(barr);
        Console.WriteLine(info);
        Console.WriteLine(barr);
    }

	public void autenticacion()
	{
		Console.Write("Ingrese Su Identificación: ");
		string cc = Console.ReadLine();

        Console.Write("Ingrese Su Clave: ");
        string clave = Console.ReadLine();

		cliente = Utilidades.obtenerCliente(cc, clave);

        if (cliente == null)
        {
           imprimir("-----------------------------  ¡USUARIO INVÁLIDO! ----------------------------------");
        }
        else
        {
           imprimir("--------------------------------- ¡Bienvenid@ "+ cliente.Nombre + "! -------------------------------- \n" + info);
           auth = true;
        }
    }

    public void canjearPuntos()
    {
        if (cliente.Puntos>1)
        {
            int canje = cliente.Puntos * 50;
            cliente.Saldo += canje;

            Utilidades.actualizarCliente(cliente);
            imprimir("|  SALDO: "+ cliente.Saldo + " | PUNTOS CANJEADOS: "+ cliente.Puntos + " VALOR: "+ canje  +" |  OPERACIÓN EXITOSA  |");
            cliente.Puntos = 0;
        }
        else
        { imprimir("| NO TIENE PUNTOS PARA CANJEAR  |"); }
        
    }

    public void retirarDinero()
    {
        DateTime fechaActual = DateTime.Now;

        if (cliente.FechaRetiro.Date != fechaActual.Date )
        {
            cliente.FechaRetiro = fechaActual;
            cliente.DineroRetirado = 0;
        }
        else if(cliente.DineroRetirado >= 2000000)
        {
            imprimir("| EXCEDIO EL TOPE DIARIO DE RETIRO |");
            return;
        }


            Console.WriteLine("¿Cuánto Desea Retirar? (Saldo Disponible: {0})(Dinero Retirado Hoy: {1}) \n¡no podrá retirar más de dos millones de pesos diarios!: ", cliente.Saldo, cliente.DineroRetirado);
            int retirar = Convert.ToInt32(Console.ReadLine());

            if (retirar< 0) { throw new Exception(); }

            if (retirar > cliente.Saldo) { imprimir("|  SALDO INSUFICIENTE   |"); }
            else if ((retirar+cliente.DineroRetirado) > 2000000) { imprimir("| EXCEDIO EL TOPE DIARIO DE RETIRO |"); }
            else
            {
                cliente.Saldo -= retirar;
                cliente.DineroRetirado += retirar;
                imprimir("|  SALDO: "+ cliente.Saldo + "  |  OPERACIÓN EXITOSA  |");
                Utilidades.actualizarCliente(cliente);
            }
    }

    public void transferirDinero()
    {
        Console.Write("Ingrese la identificación del usuario destinatario: ");
        string CCDestinatario = Console.ReadLine();
        Cliente destinatario = Utilidades.obtenerCliente(CCDestinatario);

        if (destinatario == null) { 
            imprimir("| USUARIO NO EXISTE |"); 
        }
        else
        {
            Console.Write("Destinatario {0}({1}) ¿Cuánto desea transferir?: ", destinatario.CC, destinatario.Nombre );
            int transferir = Convert.ToInt32(Console.ReadLine());

            if(transferir < 0) { throw new Exception(); }

            if (transferir > cliente.Saldo)
            {
                imprimir("| NO TIENE DINERO SUFICIENTE  |");
            }
            else
            {
                cliente.Saldo -= transferir;
                destinatario.Saldo += transferir;

                Utilidades.actualizarCliente(cliente);
                Utilidades.actualizarCliente(destinatario, true);
                imprimir("|  SALDO: "+ cliente.Saldo + "  |  OPERACIÓN EXITOSA  |");
            }
        }
        

    }

    public void cerrarSesion(bool salir=false)
    {
        cliente = null;
        auth = false;
        imprimir("--------------------------  SESIÓN CERRADA --------------------------");
        if (salir){ Environment.Exit(0); } 
    }

}
