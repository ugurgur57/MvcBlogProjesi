using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.DataModel
{
    public class Etiket
    {
        public int EtiketId { get; set; }

        [Required(ErrorMessage = "Lütfen Etiket İçetiğini Giriniz!")]
        [StringLength(20, ErrorMessage = "Etiket 20 karakterden uzun olmamalıdır!")]
        public string Icerik { get; set; }

        //Bir etiket bir çok makalede bulunabilir.
        public virtual List<Makale> Makales { get; set; }
    }
}