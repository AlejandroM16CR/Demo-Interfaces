using Xunit;

namespace Contratos.Pruebas;

public class EjercicioTests
{
    [Fact]
    public void ProcesarReserva_ConProveedorFalso_CalculaElTotalSinPedirDatos()
    {
        var calculadoraFalsa = new CalculadoraPrecioFalsa();
var proveedorFalso = new ProveedorSolicitudFalso();


var procesador = new ProcesadorDeReserva(calculadoraFalsa, proveedorFalso);

decimal total = procesador.CalcularTotal();

Assert.Equal(100000m, total);
    }
}


