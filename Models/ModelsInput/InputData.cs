using ApiCreacionDocs.Models.ModelsOuput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models
{
    public class InputData
    {
        public string Credenciales { get; set; }
        public string IdentificadorTramite { get; set; }
        public string IdPersona { get; set; }
        public InformacionDocs.InputReferenciaPago dataReferenciaPago { get; set; }
        public InformacionDocs.InputCaratula dataCaratula { get; set; }
        public InformacionDocs.InputPagare dataPagare { get; set; }
        public InformacionDocs.InputSolicitud dataSolicitud { get; set; }
        public InformacionDocs.InputContratoConsumo dataContratoConsumo { get; set; }
        public InformacionDocs.InputEstipulacion dataEstipulacion { get; set; }
        public InformacionDocs.InputTablaAmortizacion dataTAmortizacion { get; set; }
        public InformacionDocs.InputArticulosLegales dataArticulosLegales { get; set; }
        public InformacionDocs.InputPresupuestoObra dataPresupuestoObra { get; set; }
        public InformacionDocs.InputEstudioSocioeconomico dataEstudioSocioeconomico { get; set; }
        public InformacionDocs.InputProyeccionObra dataProyeccionObra { get; set; }
        public InformacionDocs.InputCartaEntrega dataCartaEntrega { get; set; }
    }
}