using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.DataModel
{
    public class Uye
    {
        public int UyeId { get; set; }

        [Required(ErrorMessage="Lütfen Adınızı Giriniz!")]
        [StringLength(20,ErrorMessage ="İsim 20 karakterden uzun olmamalıdır!")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz!")]
        [StringLength(20, ErrorMessage = "Soyisim 20 karakterden uzun olmamalıdır!")]
        public string Soyad { get; set; }

        [Required(ErrorMessage = "Lütfen Email Giriniz!")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email Formatına uygun giriş yapınız!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz!")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Required(ErrorMessage = "Lütfen Üyelik Tarihini Giriniz!")]
        [DataType(DataType.DateTime, ErrorMessage = "Lütfen tarih formatına uygun giriniz!")]
        public string Tarih { get; set; }

        //Bir üyenin birden çok makalesi olabilir.
        public virtual List<Makale> Makales { get; set; }

        //Bir üyenin birden çok yorum yapabilir.
        public virtual List<Yorum> Yorums { get; set; }
    }
}