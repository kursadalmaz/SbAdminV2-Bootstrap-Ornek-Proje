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
    
    public partial class cocuk
    {
        public int cocuk_no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string cinsiyet { get; set; }
        public System.DateTime dogum_tarihi { get; set; }
        public int dogu_yeri { get; set; }
        public int personel_no { get; set; }
    
        public virtual ilce ilce { get; set; }
        public virtual personel personel { get; set; }
    }
}
