using System;

public class EmpleadoGerente : Empleado
{
    public decimal PorcentajeBono { get; set; }

    public EmpleadoGerente(string nombre, decimal sueldoBase, decimal porcentajeBono)
        : base(nombre, sueldoBase)
    {
        // TODO: Inicializar el porcentaje de bono.
    }

    public  decimal CalcularSueldo()
    {
        // TODO: Calcular sueldo con bono porcentual.
        // Convención: 15 representa 15%.
        throw new NotImplementedException();
    }

    public override void MostrarInformacion()
    {
        // TODO: Reutilizar el método base y mostrar el porcentaje.
    }
}
