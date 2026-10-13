using System;

public class EmpleadoAdministrativo : Empleado
{
    public decimal Bono { get; set; }

    public EmpleadoAdministrativo(string nombre, decimal sueldoBase, decimal bono)
        : base(nombre, sueldoBase)
    {
        // TODO: Inicializar el bono.
    }

    public  decimal CalcularSueldo()
    {
        // TODO: Calcular sueldo base más bono.
        throw new NotImplementedException();
    }

    public  void MostrarInformacion()
    {
        // TODO: Reutilizar el método de la clase base y mostrar el bono.
    }

    public void GenerarReporte()
    {
        // TODO: Mostrar un mensaje de generación de reporte.
    }
}
