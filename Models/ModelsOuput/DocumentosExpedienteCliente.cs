using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models.ModelsOuput
{
    public class DocumentosExpedienteCliente
    {
       
        public string Id { get; set; }
        public string Clave_Origen { get; set; }
        public DateTime Fecha_Emision { get; set; }
        public DateTime Fecha_Vigencia { get; set; }
        public string Tipo_Documento { get; set; }
        public string Tipo_Expediente { get; set; }
        public string Clave_Expediente { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string URL { get; set; }
        public string Documento_data { get; set; }

    }
}
