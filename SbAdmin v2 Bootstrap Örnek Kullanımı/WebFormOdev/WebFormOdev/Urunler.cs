//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFormOdev
{
    using System;
    using System.Collections.Generic;
    
    public partial class Urunler
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public Nullable<int> TedarikciID { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<int> BirimFiyati { get; set; }
    
        public virtual Kategoriler Kategoriler { get; set; }
        public virtual Kategoriler Kategoriler1 { get; set; }
        public virtual Tedarikciler Tedarikciler { get; set; }
    }
}
