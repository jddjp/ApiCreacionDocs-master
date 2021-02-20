using DinkToPdf;
using DinkToPdf.Contracts;
using ApiCreacionDocs.Interfaces;
using ApiCreacionDocs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using ApiCreacionDocs.Models.ModelsOuput;

using Newtonsoft.Json;
using static ApiCreacionDocs.Models.InformacionDocs;

namespace ApiCreacionDocs.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IConverter _converter;
        private readonly IRazorRendererHelper _razorRendererHelper;


        public DocumentService(
            IConverter converter,
            IRazorRendererHelper razorRendererHelper)
        {
            _converter = converter;
            _razorRendererHelper = razorRendererHelper;
        }

        //Implementar interfaces de IDocumentService
        //Recibe el modelo que devuelve la informacion en la busquedade datos 
        //Terminado Ya trae la informacion del front para llenar el pagare
        public byte[] GeneratePdfPagare(InputPagare data)
        {
            var PagareVistaModel = data;
            //Modelo de Datos para Llenar el Template 
            var partialName = "/Views/pdfPagare/Pagare.cshtml";//Vistas Template para crear el PDF
            ////Renderiza la vista le pasa el Template y el modelo de datos 
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent); //Retornamos el metodo generador de pdf 
        }
        //Terminado 
        public byte[] GeneratePdfEstipulacion()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfEstipulacion/Estipulacion.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminado 
        public byte[] GeneratePdfCaratula(/*OutputPagare data*/)
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfCaratula/Caratula.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminado 
        public byte[] GeneratePdfArticulosLegales(/*OutputPagare data*/)
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfArticulosLegales/ArticulosLegales.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdfArticulos(htmlContent);
        }
        //Terminado
        public byte[] GeneratePdfEstudioSocioeconomico()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfEstudioSocioeconomico/EstudioSocioeconomico.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminado
        public byte[] GeneratePdfProyeccionObra()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfProyeccionObra/ProyeccionObra.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminado 
        public byte[] GeneratePdfPresupuestoObra()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfPresupuestoObra/PresupuestoObra.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminado
        public byte[] GeneratePdfCartaEntregaRecepcion()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfCartaEntregaRecepcion/CartaEntregaRecepción.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //en pruebas Revision
        public byte[] GeneratePdfReferenciaPago()
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfReferenciaPago/ReferenciaPago.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //Terminada en revision
        public byte[] GeneratePdfCartaTablaAmortizacion(/*OutputPagare data*/)
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfTablaAmortizacion/TablaAmortizacion.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //en proceso
        public byte[] GeneratePdfCartaContrato(/*OutputPagare data*/)
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfContrato/Contrato.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdf(htmlContent);
        }
        //En proceso
        public byte[] GeneratePdfSolicitud(/*OutputPagare data*/)
        {
            var PagareVistaModel = GetPagareModel();
            var partialName = "/Views/pdfSolicitud/Solicitud.cshtml";
            var htmlContent = _razorRendererHelper.RenderPartialToString(partialName, PagareVistaModel);
            return GeneratePdfSolicitud(htmlContent);
        }

        //Metodo Generador de pdfs
        private byte[] GeneratePdf(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 4/*,Bottom=4,Left=4,Right=4 */},

            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },
            };
            var htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };

            return _converter.Convert(htmlToPdfDocument);
        }
        //Metodo Generador de pdfs Encabezado Articulos Legales
        private byte[] GeneratePdfArticulos(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 18, Bottom = 18 },

            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontSize = 7, HtmUrl = @"Views\pdfArticulosLegales\header.html", Line = false },
                FooterSettings = { FontSize = 7, Right = "Page [page] of [toPage]", HtmUrl = @"Views\pdfArticulosLegales\footer.html", Line = false },
            };
            var htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };

            return _converter.Convert(htmlToPdfDocument);
        }
        //Metodo Generador de pdfs Encabezado Solicitud
        private byte[] GeneratePdfSolicitud(string htmlContent)
        {
            var globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings { Top = 18, Bottom = 18 },

            };
            var objectSettings = new ObjectSettings
            {
                PagesCount = true,
                HtmlContent = htmlContent,
                WebSettings = { DefaultEncoding = "utf-8" },
                HeaderSettings = { FontSize = 7, HtmUrl = @"Views\pdfSolicitud\header.html", Line = false },
                FooterSettings = { FontSize = 7, Right = "Page [page] of [toPage]", Line = false },
            };
            var htmlToPdfDocument = new HtmlToPdfDocument()
            {
                GlobalSettings = globalSettings,
                Objects = { objectSettings },
            };

            return _converter.Convert(htmlToPdfDocument);
        }
        //Modelo estatico 
        //Modelo estatico de datos
        private OutputPagare GetPagareModel()
        {
            var outputpagare = new OutputPagare
            {
                NumeroContrato = "283362",
                NumeroPagare = "2220028840",
                Cantidadpagare = "74,923.96",
                CantidadpagareNumLetras = "74,923.96(SETENTA Y CUATRO MIL NOVECIENTOS VEINTITRES PESOS CON 96 / 100 M.N.) ",
                PersonaNombre = "JESUS RAMOS LOPEZ",
                PersonaDomicilio = "AMAPOLAS # 176",
                PersonaColonia = "CHUPADEROS C.P. 98471",
                PersonaCiudad = "VILLA DE COS, ZACATECAS",
                PersonaTelefono = "4921048265",
                NumAmortizaciones = "36",
                DiaUltimoPago = "15",
                MesUltimoPago = "AGOSTO",
                AnioUltimoPago = "2021",
                AnioPrimerpago = "2020",
                DiaPrimerPago = "10",
                MesPrimerPago = "FEBRERO",
                PagosPeridicidad = "QUINCENALES",
                CiudadEmite = "ZACATECAS, ZACATECAS",
                PaisEmite = "MÉXICO",
                TasaOrdinaria = "60.54 ",
                TasaMoratoria = "12.61",
                ColoniaEmite = "LUIS DONALDO COLOSIOC.P. 98046",
                DireccionEmite = "BOULEVARD HEROES DE CHAPULTEPEC # 1402 A Int. LOC. 8",
                CantidadPagosnumeroyletras = "2,081.22 (DOS MIL OCHENTA Y UNO PESOS CON 22 / 100 M.N.)",
                FechaCreacionPagare = new DateTime()
            };
            var jsonPatientList = JsonConvert.SerializeObject(outputpagare);
            var c = jsonPatientList;
            return outputpagare;
        }


    }
}