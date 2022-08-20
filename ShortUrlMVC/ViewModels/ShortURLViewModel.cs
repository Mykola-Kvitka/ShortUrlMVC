using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShortUrlMVC.PL.ViewModels
{
    public class ShortURLViewModel
    {
        public string OrginalURLId { get; set; }

        public string OwnerId { get; set; }

        public string Short { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
