using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBlogProjesi.DataModel
{
    //DbContext sınıfından implement edilmeli, böylece bu sınıfın özelliklerini kullanabiliriz veya yararlanabiliriz. Veritabanı oluştururken WebConfig içerisindeki ConnectionString dikkate alınacağından, oluşmasını istediğimiz veritabanın özelliklerini WebConfig içerisinde belirtmeliyiz. Burada dikkat edilmesi gereken en önemli nokta , add name ismi ile DBContext sınıfımızın ismi mutlaka aynı olmalıdır.
    public class BlogDbContext : DbContext
    {
        //Veritabanımızda oluşmasını istediğimiz tablolara karşılık gelmek üzere tüm sınıflarımızı DbSet içerisinde çağırmalıyız.

        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Makale> Makales { get; set; }
        public DbSet<Yorum> Yorums { get; set; }
        public DbSet<Etiket> Etikets { get; set; }
    }
}