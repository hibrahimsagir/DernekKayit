//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DernekKayit
{
    using System;
    using System.Collections.Generic;
    
    public partial class KasaIslemTip
    {
        public KasaIslemTip()
        {
            this.Kasa = new HashSet<Kasa>();
        }
    
        public byte Id { get; set; }
        public string IslemAdi { get; set; }
        public Nullable<System.DateTime> KayitTarihi { get; set; }
        public Nullable<bool> Silindi { get; set; }
    
        public virtual ICollection<Kasa> Kasa { get; set; }
    }
}
