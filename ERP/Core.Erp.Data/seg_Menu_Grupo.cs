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
    
    public partial class seg_Menu_Grupo
    {
        public seg_Menu_Grupo()
        {
            this.seg_Menu_Grupo_x_seg_Menu_Item = new HashSet<seg_Menu_Grupo_x_seg_Menu_Item>();
        }
    
        public string Codigo_Grupo { get; set; }
        public string Descripcion { get; set; }
        public bool AllowMinimize { get; set; }
        public int ImageIndex { get; set; }
        public bool ShowCaptionButton { get; set; }
        public bool Visible { get; set; }
        public string Codigo_Pagina { get; set; }
        public int position { get; set; }
    
        public virtual seg_Menu_Pagina seg_Menu_Pagina { get; set; }
        public virtual ICollection<seg_Menu_Grupo_x_seg_Menu_Item> seg_Menu_Grupo_x_seg_Menu_Item { get; set; }
    }
}