//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Af_Activo_fijo_Categoria
    {
        public Af_Activo_fijo_Categoria()
        {
            this.Af_Activo_fijo = new HashSet<Af_Activo_fijo>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdCategoriaAF { get; set; }
        public int IdActivoFijoTipo { get; set; }
        public string CodCategoriaAF { get; set; }
        public string Descripcion { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
        public string Estado { get; set; }
        public string cod_tipo { get; set; }
    
        public virtual ICollection<Af_Activo_fijo> Af_Activo_fijo { get; set; }
        public virtual Af_Activo_fijo_tipo Af_Activo_fijo_tipo { get; set; }
    }
}