
using ApiCreacionDocs.Models.ModelsOuput;
using static ApiCreacionDocs.Models.InformacionDocs;

namespace ApiCreacionDocs.Interfaces
{
    public interface IDocumentService
    {

        byte[] GeneratePdfPagare(InputPagare data);
        byte[] GeneratePdfEstipulacion(/*OutputPagare data*/);
        byte[] GeneratePdfCaratula(/*OutputPagare data*/);
        byte[] GeneratePdfArticulosLegales(/*OutputPagare data*/);
        byte[] GeneratePdfEstudioSocioeconomico(/*OutputPagare data*/);
        byte[] GeneratePdfProyeccionObra(/*OutputPagare data*/);
        byte[] GeneratePdfPresupuestoObra(/*OutputPagare data*/);
        byte[] GeneratePdfCartaEntregaRecepcion();
        byte[] GeneratePdfReferenciaPago(/*OutputPagare data*/);
        byte[] GeneratePdfCartaTablaAmortizacion(/*OutputPagare data*/);
        byte[] GeneratePdfCartaContrato(/*OutputPagare data*/);
        byte[] GeneratePdfSolicitud(InputSolicitud data);
    }
}