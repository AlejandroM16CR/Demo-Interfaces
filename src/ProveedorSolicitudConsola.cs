namespace Contratos;

public class ProveedorSolicitudConsola : IProveedorDeSolicitud
{
    public SolicitudDeReserva ObtenerSolicitud()
    {

        Console.Write("Tipo de cliente (REGULAR, CORPORATIVO, ESTUDIANTIL): ");
        string tipoCliente = Console.ReadLine() ?? "REGULAR";

        Console.Write("Tarifa por hora: ");
        decimal.TryParse(Console.ReadLine(), out decimal tarifaHora);

        Console.Write("Cantidad de horas: ");
        int.TryParse(Console.ReadLine(), out int horas);

        Console.Write("¿Con catering? (true/false): ");
        bool conCatering = (Console.ReadLine() ?? "").Trim().ToLower() == "true";

        Console.Write("¿Con proyector? (true/false): ");
        bool conProyector = (Console.ReadLine() ?? "").Trim().ToLower() == "true";

        return new SolicitudDeReserva
        {
            TipoCliente = tipoCliente,
            TarifaHora = tarifaHora,
            Horas = horas,
            ConCatering = conCatering,
            ConProyector = conProyector,
        };
    }
}