using System;

public class Cliente: Usuario
{
	private double saldo;
	private int puntos;
    private double dineroRetirado;
    private DateTime fechaRetiro;



    public Cliente(string cc, string clave, string nombre, string edad, int puntos, double saldo, double dineroRetirado, DateTime fechaRetiro) : base(cc, clave, nombre, edad)
    {
        this.saldo = saldo;
        this.puntos = puntos;
        this.dineroRetirado = dineroRetirado;
        this.fechaRetiro= fechaRetiro;
    }

    public double Saldo { get => saldo; set => saldo=value; }
    public int  Puntos{ get => puntos; set => puntos=value; }
    public double DineroRetirado { get => dineroRetirado; set => dineroRetirado=value; }
    public DateTime FechaRetiro { get => fechaRetiro; set => fechaRetiro=value; }





}
