using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models.ModelsOuput
{
    public class OutputPagare
    {


        [Key]
        public String NumeroContrato { get; set; }
        public String NumeroPagare { get; set; }
        public String Cantidadpagare { get; set; }
        public String CantidadpagareNumLetras { get; set; }
        public String PersonaNombre { get; set; }
        public String PersonaDomicilio { get; set; }
        public String PersonaColonia { get; set; }
        public String PersonaCiudad { get; set; }
        public String PersonaTelefono { get; set; }
        public String NumAmortizaciones { get; set; }
        public String DiaUltimoPago { get; set; }
        public String MesUltimoPago { get; set; }
        public String AnioUltimoPago { get; set; }
        public String AnioPrimerpago { get; set; }
        public String DiaPrimerPago { get; set; }
        public String MesPrimerPago { get; set; }
        public String PagosPeridicidad { get; set; }
        public String CiudadEmite { get; set; }
        public String PaisEmite { get; set; }
        public String TasaOrdinaria { get; set; }
        public String TasaMoratoria { get; set; }
        public String ColoniaEmite { get; set; }
        public String DireccionEmite { get; set; }
        public String CantidadPagosnumeroyletras { get; set; }
        public DateTime FechaCreacionPagare { get; set; }
    }
}