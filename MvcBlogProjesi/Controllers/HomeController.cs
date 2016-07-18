using MvcBlogProjesi.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProjesi.Controllers
{
    public class HomeController : Controller
    {
        BlogDbContext dc = new BlogDbContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SonMakaleler()
        {
            //AraKatmandaki(DbContext) makaleler sınıfından son eklenen 3 makaleyi görüntüleyecek Partial View için modelliste oluşturulmalıyız.
            List<Makale> makaleListe = dc.Makales.OrderByDescending(m => m.Tarih).Take(3).ToList();
            return PartialView(makaleListe);
        }
        public ActionResult SonYorumlar()
        {
            //AraKatmandaki(DbContext) makaleler sınıfından son eklenen 3 makaleyi görüntüleyecek Partial View için modelliste oluşturulmalıyız.
            List<Yorum> yorumListe = dc.Yorums.OrderByDescending(m => m.Tarih).Take(3).ToList();
            return PartialView(yorumListe);
        }
        public ActionResult CokKullanilanEtiketler()
        {
            //En çok makale ile ilişkilendiren 5 adet etiketi görüntüleyecek PartialView için modelliste oluşturmalıyız.
            List<Etiket> etiketliste = dc.Etikets.OrderByDescending(e => e.Makales.Count).Take(5).ToList();

            return PartialView(etiketliste);
        }
        public ActionResult MakalelerByEtiket(int id)
        {
            var makaleliste = (from e in dc.Etikets
                               where e.EtiketId == id
                               select e.Makales).ToList();
            return View(makaleliste[0]);//Burada veriler içiçe liste(koleksiyon halinde geldiği için (ki çoğunlukla bir tane olacaktır.) içerideki ilk listeyi [0] indeksi ile çekip gönderiyoruz.
        }
        public ActionResult MakaleByYorum(int id)
        {
            Makale yorumMakale = (from y in dc.Yorums
                               where y.YorumId == id
                               select y.Makale).FirstOrDefault();
            return View(yorumMakale);
        }
    }
}