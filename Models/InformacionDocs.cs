using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCreacionDocs.Models
{
    public class InformacionDocs
    {
        public class InputPagare
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
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

        public class InputEstipulacion
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
            public DateTime DiaMesAnioDispersion { get; set; }
            public string RetenedorPagos { get; set; }
            public string TrabajoArea { get; set; }
            public string ClaveEmpleado { get; set; }
            public string ContratoNumero { get; set; }
            public string PlazoCreditoMeses { get; set; }
            public string PlazoCreditoQNAS { get; set; }
            public string MontoPrestamoSinInterSeguroLetra { get; set; }
            public string NombreCliente { get; set; }
            public string DireccionCliente { get; set; }
            public string TelefonoClientePart { get; set; }
            public string TelefonoClienteOficina { get; set; }
            public string NoCuentaCTAClaveDeposito { get; set; }
            public string MunicipioFirma { get; set; }
            public string EstadoFirma { get; set; }
            public string DiaMesLetraAnioDispersion { get; set; }
            public string MunicipioEstado { get; set; }
            public string TrabajoPuesto { get; set; }
            public string CredTotSinInterSeguro { get; set; }
            public string Comisionotorgamiento { get; set; }
            public string Creditosininteresseguroletra { get; set; }
            public string SeguroTotalSin1Pago { get; set; }
            public string SeguroTotalSin1PagoLetra { get; set; }
            public string CredTotal { get; set; }
            public string CredTotalLetra { get; set; }
            public string CredNumPagos { get; set; }
            public string CREDTIPOPERIODICO { get; set; }
            public string CredMontoParcialidad { get; set; }
            public string CREDMONTOPARCIALIDADLETRA { get; set; }
            public string TRABAJONOMBRE { get; set; }
            public string E_BANCO_CTA { get; set; }
            public string E_BANCO_CLABE { get; set; }
            public string EMPRESACLAVE_DEDUCCION { get; set; }
            public string LEPAGANNOMINACADA { get; set; }
            public string CLIENTERFC { get; set; }
            public string Sexo { get; set; }


        }

        public class InputTablaAmortizacion
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
            public String FechadeOtorgamiento { get; set; }
            public String FechadeVencimiento { get; set; }
            public String NodePagare { get; set; }
            public String MontodeRenovación { get; set; }
            public String TipodeCredito { get; set; }
            public String NombreCliente { get; set; }
            public String Domicilio { get; set; }
            public String Colonia { get; set; }
            public String Ciudad { get; set; }
            public String Telefono { get; set; }
            public List<TAmortizacion> listTamortizacion { get; set; }
        }
        public class TAmortizacion
        {
            public String inicio { get; set; }
            public String vencimiento { get; set; }
            public String saldoInicial { get; set; }
            public String capital { get; set; }
            public String interes { get; set; }
            public String iva { get; set; }
            public String subtotal { get; set; }
            public String comision { get; set; }
            public String seguro { get; set; }
            public String pago { get; set; }
            public String saldoFinal { get; set; }

        }

        public class InputCaratula
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
            public String CAT { get; set; }
            public String TasaInsolutra { get; set; }
            public String TasaMoraa { get; set; }
            public String MontoLineaCredito { get; set; }
            public String MontoTotalPagar { get; set; }
            public String CreditoPeriodicidad { get; set; }
            public String CreditoPlazo { get; set; }
            public String ClienteNombreClompleto { get; set; }

        }
        public class InputEstudioSocioeconomico
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }
        public class InputContratoConsumo
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
            public String RepresentanteLegal { get; set; }
            public String ClienteNomCompleto { get; set; }
            public String SucursalDomicilio { get; set; }
            public String SucursalColonia { get; set; }
            public String SucursalCP { get; set; }
            public String TasaInsoluta { get; set; }
            public String CreditoTipoPeriodicidad { get; set; }
            public String TasaMora { get; set; }
            public String CreditoTotal { get; set; }
            public String CreditoTotalLetra { get; set; }
            public String CreditoPlazo { get; set; }
            public String CreditoNoPagos { get; set; }
            public String CreditoTipoCredito { get; set; }
            public String CreditoMontoParcialidad { get; set; }
            public String CreditoMontoParcialidadLetra { get; set; }
            public String ComisionPagoFijo { get; set; }
            public String ComisionPagoFijoLetra { get; set; }
            public String PorcentajeComision { get; set; }
            public String ReferenciaBanco { get; set; }
            public String SucursalMunicipio { get; set; }
            public String SucursalEstado { get; set; }
            public String CreditoMaximoCtaCorrriente { get; set; }
            public String CreditoMaximoCtaCorrrienteLetra { get; set; }
            public String EsCheque { get; set; }
            public String EsTarjeta { get; set; }
            public String BancoCuenta { get; set; }
            public String BancoCliente { get; set; }
            public String EsTransferencia { get; set; }
            public String BancoClabe { get; set; }
            public String BancoClienteClabe { get; set; }
            public String EspagoVentanilla { get; set; }
            public String MunicipioFirma { get; set; }
            public String MunicipioEstado { get; set; }
            public String DiaDispersion { get; set; }
            public String MesDispersion { get; set; }
            public String AnioDispersion { get; set; }
        }
        public class InputReferenciaPago
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }
            public String FechaOperacion { get; set; }
            public String PagoPeriodicidadMonto { get; set; }
            public String ClienteNombre { get; set; }
            public String Periodicidad { get; set; }
            public String NoCredito { get; set; }
            public String FormaPagoCTABancariaBBVA { get; set; }
            public String FormaPagoReferenciaConceptoPagoBBVA { get; set; }
            public String FormaPagoReferenciaOxxo { get; set; }
            public String FormaPagoBancoInstitucionOtros { get; set; }
            public String FormaPagoClabeOtros { get; set; }
            public String ConceptoMotivoPagoOtros { get; set; }
        }
        public class InputSolicitud
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }

        public class InputArticulosLegales
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }
        public class InputPresupuestoObra
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }
        public class InputProyeccionObra
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }
        public class InputCartaEntrega
        {
            public string TipoExpediente { get; set; }
            public string TipoSubExpediente { get; set; }
            public string formato { get; set; }

            public string Version { get; set; }

        }



    }
}