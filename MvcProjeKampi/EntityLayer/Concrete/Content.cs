using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public class Content
    {
        //burada 5 başlık vardır bunlara veri girişi yaparız
       [Key]
        public int ContentId { get; set; }
        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //heading ile ilişki kuruldu id üzerinden
        public int HeadingId { get; set; }
        public virtual Heading Heading { get; set; }
        //yazarın ıd ile bağlantı kuruldu 

       public int? WriterId { get; set; }
       public virtual Writer Writer { get; set; }

    }
}
