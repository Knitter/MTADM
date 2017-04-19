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
    
    public partial class Arma : Objeto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arma()
        {
            this.Monstros = new HashSet<Monstro>();
            this.PersonagensAsPrincipal = new HashSet<Personagem>();
            this.PersonagensAsSecundaria = new HashSet<Personagem>();
        }
    
        public int Ataque { get; set; }
        public int Defesa { get; set; }
        public int ModeloArmaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Monstro> Monstros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personagem> PersonagensAsPrincipal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personagem> PersonagensAsSecundaria { get; set; }
        public virtual ModeloArma ModeloArma { get; set; }
    }
}
