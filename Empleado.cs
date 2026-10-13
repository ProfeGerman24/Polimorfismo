using System;

public abstract class Empleado
{
    public string Nombre { get; set; }
    public decimal SueldoBase { get; set; }

    public Empleado(string nombre, decimal sueldoBase)
    {
        // TODO: Inicializar las propiedades.
    }

    public abstract decimal CalcularSueldo();

    public virtual void MostrarInformacion()
    {
        // TODO: Mostrar nombre y sueldo calculado.
    }
}
