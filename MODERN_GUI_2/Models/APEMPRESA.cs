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
    
    public partial class APEMPRESA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APEMPRESA()
        {
            this.APACCESO = new HashSet<APACCESO>();
            this.APCERTIFICADO = new HashSet<APCERTIFICADO>();
            this.APCORREO = new HashSet<APCORREO>();
            this.APCORREOSOPORTE = new HashSet<APCORREOSOPORTE>();
            this.APOPERADOR = new HashSet<APOPERADOR>();
            this.APRUTAARCHIVO = new HashSet<APRUTAARCHIVO>();
            this.APSUCURSAL = new HashSet<APSUCURSAL>();
        }
    
        public int EMPRESA { get; set; }
        public string NOMBRE { get; set; }
        public string DIRECCION { get; set; }
        public string RUC { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
        public string TIPOEMPRESA { get; set; }
        public bool ESPECIAL { get; set; }
        public string GERENTE { get; set; }
        public string RUCG { get; set; }
        public string TELEFONOG { get; set; }
        public string OBSERVACION { get; set; }
        public bool FACTURA { get; set; }
        public bool NCR { get; set; }
        public bool GUIA { get; set; }
        public bool RETENCION { get; set; }
        public bool NDB { get; set; }
        public string ODBCE { get; set; }
        public string USUARIOE { get; set; }
        public string CLAVEE { get; set; }
        public string WEBSRIPRUEBA { get; set; }
        public string WEBSRIPROD { get; set; }
        public string CONEXION { get; set; }
        public string CORREOEMP { get; set; }
        public string CLAVEEMP { get; set; }
        public string LOGOEMPRESA { get; set; }
        public int AMBIENTEFACTURACION { get; set; }
        public string WSAUTORIZACIONPRUEBA { get; set; }
        public string WSAUTORIZACIONPRODUCCION { get; set; }
        public string CODIGOCONTRIBUYENTE { get; set; }
        public string DIRECCIONFTP { get; set; }
        public string CLAVEFTP { get; set; }
        public string USUARIOFTP { get; set; }
        public string ENVIAWEB { get; set; }
        public string WSEMPRESA { get; set; }
        public bool CLAVEREGISTRADA { get; set; }
        public bool EDITASCRIP { get; set; }
        public string TIPOBASE { get; set; }
        public string WEBSERVICERECPRUEBAS { get; set; }
        public string WEBSERVICERECPPRODUCCION { get; set; }
        public string WEBSERVIAUTOPRUEBAS { get; set; }
        public string WEBSERVIAUTOPRODUCCION { get; set; }
        public string MESCONTABLE { get; set; }
        public int MESCONTROL { get; set; }
        public int MESCONTABLESIS { get; set; }
        public string FECHAP { get; set; }
        public string CONORACLE { get; set; }
        public string CONEXTERNA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APACCESO> APACCESO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APCERTIFICADO> APCERTIFICADO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APCORREO> APCORREO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APCORREOSOPORTE> APCORREOSOPORTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APOPERADOR> APOPERADOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APRUTAARCHIVO> APRUTAARCHIVO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APSUCURSAL> APSUCURSAL { get; set; }
    }
}
