//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTADM
{
    using System;
    using System.Collections.Generic;
    
    public partial class Objeto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int AreaId { get; set; }
        public int ModeloObjetoId { get; set; }
    
        public virtual Area Area { get; set; }
        public virtual ModeloObjeto ModeloObjeto { get; set; }
    }
}
