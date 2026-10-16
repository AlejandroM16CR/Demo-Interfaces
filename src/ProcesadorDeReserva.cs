namespace Contratos;

// Buen diseño: recibe el contrato por constructor. No le importa qué
// implementación use, mientras cumpla ICalculadoraDePrecio.
public class ProcesadorDeReserva
{
    private readonly ICalculadoraDePrecio _calculadora;
    private readonly IProveedorDeSolicitud _proveedorSolicitud;

    public ProcesadorDeReserva(ICalculadoraDePrecio calculadora, IProveedorDeSolicitud proveedorSolicitud)
    {
        _calculadora = calculadora;
        _proveedorSolicitud = proveedorSolicitud;
    }

    public decimal CalcularTotal()
    {
        var solicitud = _proveedorSolicitud.ObtenerSolicitud();
        return _calculadora.Calcular(solicitud).Total;
    }
}
