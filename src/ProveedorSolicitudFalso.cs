namespace Contratos;



public class ProveedorSolicitudFalso : IProveedorDeSolicitud
{
    public SolicitudDeReserva ObtenerSolicitud()
    {
        return new SolicitudDeReserva
        {
            TipoCliente = "CORPORATIVO",
            TarifaHora = 1000m,
            Horas = 4,
            ConCatering = true,
            ConProyector = false,
        };
    }
}