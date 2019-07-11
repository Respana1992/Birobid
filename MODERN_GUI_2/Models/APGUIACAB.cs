//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODERN_GUI_2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class APGUIACAB
    {
        public decimal ID { get; set; }
        public int EMPRESA { get; set; }
        public int SUCURSAL { get; set; }
        public string SERIE { get; set; }
        public long NUMERO { get; set; }
        public long NUMGUIA { get; set; }
        public System.DateTime FECHAEMI { get; set; }
        public string RUCCHOFER { get; set; }
        public string ANIOCAMION { get; set; }
        public string NUMAUTORIZACIONDOC { get; set; }
        public string CAMION { get; set; }
        public string MOTIVO { get; set; }
        public string PLACA { get; set; }
        public string NOMBRECHOFER { get; set; }
        public string NOMBRECLIENTE { get; set; }
        public string RUCCLI { get; set; }
        public string DIRECCION { get; set; }
        public string TELEFONOS { get; set; }
        public string CORREO { get; set; }
        public string CLAVEACCESO { get; set; }
        public string NOAUTORIZACION { get; set; }
        public string ARCHIVOSOLO { get; set; }
        public string ARCHIVOFIRMA { get; set; }
        public string ARCHIVOAUTORIZACION { get; set; }
        public string ARCHIVOPDF { get; set; }
        public string ARCHIVOERROR { get; set; }
        public string CONCEPTOERROR { get; set; }
        public string CODIGOERROR { get; set; }
        public Nullable<System.DateTime> FECHAREGISTRO { get; set; }
        public string HORAREGISTRO { get; set; }
        public Nullable<System.DateTime> FECHAPROCESO { get; set; }
        public string HORAPROCESO { get; set; }
        public string ESTADOPROCESO { get; set; }
        public string TIPO { get; set; }
        public string SUBIDOALAWEB { get; set; }
        public string ACTUALIZADOSC { get; set; }
        public Nullable<System.DateTime> FECHADESDE { get; set; }
        public Nullable<System.DateTime> FECHAHASTA { get; set; }
        public string NOCERTIFICADO { get; set; }
        public string NOMCIUDAD { get; set; }
        public string DETALLE { get; set; }
        public string BENEFICIARIO { get; set; }
        public string VALORENLETRAS { get; set; }
        public string CODCLIENTE { get; set; }
        public string NombreDocumento { get; set; }
        public Nullable<int> estadoFecEmi { get; set; }
        public string TIPOIDENTIFICACION { get; set; }
        public string DESPACHO { get; set; }
        public string ENVIACORREO { get; set; }
        public string ERRORCORREO { get; set; }
        public byte[] clavebyte { get; set; }
        public string REGION { get; set; }
        public string ANULADO { get; set; }
    
        public virtual APEMPRESA APEMPRESA { get; set; }
    }
}
