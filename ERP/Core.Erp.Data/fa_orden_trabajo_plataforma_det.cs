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
    
    public partial class fa_orden_trabajo_plataforma_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdOrdenTrabajo_Pla { get; set; }
        public int secuencia { get; set; }
        public string descrip_equipo_movi { get; set; }
        public string punto_partida { get; set; }
        public string punto_llegada { get; set; }
        public Nullable<System.TimeSpan> hora_ini { get; set; }
        public Nullable<System.TimeSpan> hora_fin { get; set; }
        public double Valor { get; set; }
    }
}