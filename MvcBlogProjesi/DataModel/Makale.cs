using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.DataModel
{
    public class Makale
    {
        public int MakaleId { get; set; }

        [Required(ErrorMessage = "Lütfen Makale Başlığı Giriniz!")]
        [StringLength(50, ErrorMessage = "Başlık 50 karakterden uzun olmamalıdır!")]
        public string Baslik { get; set; }

        [Required(ErrorMessage = "Lütfen Makale İçeriğini Giriniz!")]
        [DataType(DataType.Html, ErrorMessage = "Makale içeriğini HTML formatına uygun giriniz")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Lütfen Makale Tarihini Giriniz!")]
        [DataType(DataType.DateTime, ErrorMessage = "Lütfen tarih formatına uygun giriniz!")]
        public string Tarih { get; set; }

        //Her makaleyi yazan bir üye vardır.
        public virtual Uye Uye { get; set; }

        //Bir makaleye birden çok yorum yapılabilir.
        public virtual List<Yorum> Yorums { get; set; }

        //Bir makalede birden çok etiket bulunabilir.
        public virtual List<Etiket> Etikets { get; set; }
    }
}