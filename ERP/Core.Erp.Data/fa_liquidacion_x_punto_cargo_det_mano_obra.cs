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
    
    public partial class fa_liquidacion_x_punto_cargo_det_mano_obra
    {
        public fa_liquidacion_x_punto_cargo_det_mano_obra()
        {
            this.fa_liquidacion_x_punto_cargo_det_mano_obra_det = new HashSet<fa_liquidacion_x_punto_cargo_det_mano_obra_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public string IdCentroCosto { get; set; }
        public decimal IdLiquidacion { get; set; }
        public int mo_secuencia { get; set; }
        public double mo_horas { get; set; }
        public double mo_precio_uni { get; set; }
        public double mo_por_ganancia { get; set; }
        public double mo_valor_ganancia { get; set; }
        public double mo_precio_total { get; set; }
        public decimal IdProducto { get; set; }
        public decimal IdActividad { get; set; }
        public decimal IdTecnico { get; set; }
    
        public virtual ICollection<fa_liquidacion_x_punto_cargo_det_mano_obra_det> fa_liquidacion_x_punto_cargo_det_mano_obra_det { get; set; }
        public virtual fa_liquidacion_x_punto_cargo fa_liquidacion_x_punto_cargo { get; set; }
    }
}