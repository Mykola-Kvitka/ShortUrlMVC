using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortUrlMVC.BLL.Models
{
    public class ShortURL
    {
        public string OrginalURLId { get; set; }

        public string OwnerId { get; set; }

        public string Short { get; set; }

        public DateTime CreateDate { get; set; }

    }
}
