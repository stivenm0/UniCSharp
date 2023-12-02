using System;

public class Usuario
{

    protected string nombre;
    protected string edad;
    protected string cc;
    protected string clave;


    public Usuario(string cc, string clave, string nombre, string edad)
    {
        this.Nombre = nombre;
        this.edad = edad;
        this.cc = cc;
        this.clave = clave;
    }

    public string Nombre { get => nombre; set => nombre=value; }
    public string  Edad{ get => edad; set => edad=value; }
    public string  CC{ get => cc; set => cc=value; }
    public string Clave { get => clave; set => clave=value; }






}
