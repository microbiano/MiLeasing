using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiLeasing.Web.Data;
using MiLeasing.Web.Data.Entities;

namespace MiLeasing.Web.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyTypesController : ControllerBase
    {
        private readonly DataContext _context;

        public PropertyTypesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PropertyTypes
        [HttpGet]
        public IEnumerable<PropertyType> GetPropertyTypes()
        {
            return _context.PropertyTypes.OrderBy(pt=>pt.Name);
        }
   
    }
}