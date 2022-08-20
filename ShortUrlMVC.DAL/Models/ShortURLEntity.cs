using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortUrlMVC.DAL.Models
{
    public class ShortURLEntity
    {
        [Key]
        [MaxLength(256)]

        public string OrginalURLId { get; set; }

        [MaxLength(64)]
        public string OwnerId { get; set; }

        [MaxLength(64)]
        public string Short { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
