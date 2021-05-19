using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RoofstockChallenge.Data;
using RoofstockChallenge.Model;
using RoofstockChallenge.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RoofstockChallenge.Business
{
    public class PropertyService : IPropertyService
    {
        private readonly RoofStockDbContext _context;
        private readonly ILogger _logger;

        //public List<>
        public PropertyService(ILogger<PropertyService> logger, RoofStockDbContext context)
        {
            _context = context;
            _logger = logger;
        }

        public List<PropertyDTO> GetProperties()
        {
            List<PropertyDTO> properties = new List<PropertyDTO>();
            var p = _context.Property.Include(x => x.Physical).ToList();
            properties = _context.Property.Include(x => x.Address).Include(x => x.Financial).Include(x => x.Physical).Select(p => new PropertyDTO {
                Address = p.Address.Address1  + " "+p.Address.City + ", "+ p.Address.State +" " +p.Address.Zip,
                GrossYield = (double)p.Financial.MonthlyRent * 12 * 100 / p.Financial.ListPrice,
                IdProperty = p.Id,
                ListPrice = p.Financial.ListPrice,
                MonthlyRent = p.Financial.MonthlyRent,
                YearBuilt = p.Physical == null ? null : p.Physical.YearBuilt
            }
            ).ToList();
            return properties;
        }
    }
}
