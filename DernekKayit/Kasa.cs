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
    
    public partial class Kasa
    {
        public int Id { get; set; }
        public byte IslemTipId { get; set; }
        public byte IslemTurId { get; set; }
        public double Tutar { get; set; }
        public System.DateTime KayitTarihi { get; set; }
        public string Aciklama { get; set; }
    
        public virtual KasaIslemTip KasaIslemTip { get; set; }
        public virtual KasaIslemTur KasaIslemTur { get; set; }
    }
}
