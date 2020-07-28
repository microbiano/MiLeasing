using Microsoft.AspNetCore.Http;
using MiLeasing.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MiLeasing.Web.Models
{
    public class PropertyImageViewModel:PropertyImage
    {       
            [Display(Name = "Image")]
            public IFormFile ImageFile { get; set; }      
    }
}
