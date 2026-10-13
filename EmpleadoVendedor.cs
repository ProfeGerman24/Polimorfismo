using System;

public class EmpleadoVendedor : Empleado
{
    public decimal Ventas { get; set; }

    public EmpleadoVendedor(string nombre, decimal sueldoBase, decimal ventas)
        : base(nombre, sueldoBase)
    {
        // TODO: Inicializar las ventas.
    }

    public  decimal CalcularSueldo()
    {
        // TODO: Calcular sueldo base más el 10% de las ventas.
        throw new NotImplementedException();
    }

    // MostrarInformacion() se hereda de Empleado sin sobrescribirlo.
}
