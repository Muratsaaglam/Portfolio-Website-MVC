//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcCV.Models.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class TblEgitimlerim
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Bu Alan� Bo� Ge�emezsiniz")]

        public string Baslik { get; set; }
        [Required(ErrorMessage = "Bu Alan� Bo� Ge�emezsiniz")]

        public string AltBaslik1 { get; set; }
        [Required(ErrorMessage = "Bu Alan� Bo� Ge�emezsiniz")]

        public string AltBaslik2 { get; set; }

        [StringLength(10,ErrorMessage ="L�tfen En Fazla 10 Karakter Giri�i Yap�n�z")]
        public string GNO { get; set; }

        [Required(ErrorMessage = "Bu Alan� Bo� Ge�emezsiniz")]
        public string Tarih { get; set; }
    }
}
