using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UrlShort.Domain.Models
{
    public class UrlEntity
    {
        [Key]
        public string ShortedUrl { get; set; }
        public string FullUrl { get; set; }
    }
}
