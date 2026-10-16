namespace Contratos;

// ¿Qué recibe?
// Nada.
//
// ¿Qué devuelve?
// Una instancia válida de SolicitudDeReserva con sus datos poblados.
//
// ¿Qué garantiza?
// Devuelve un objeto SolicitudDeReserva listo para ser procesado
//
// ¿Qué promete NO hacer?
// Promete no realizar cálculos de precios ni modificar el estado de la reserva

public interface IProveedorDeSolicitud
{
    SolicitudDeReserva ObtenerSolicitud();
}

