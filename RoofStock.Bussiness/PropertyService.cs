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
            properties = _context.Property.Include(x => x.Address).Include(x => x.Financial).Select(p => new PropertyDTO {
                Address = p.Address.Address1,
                GrossYield = (double)p.Financial.MonthlyRent * 12 *100 / p.Financial.ListPrice,
                IdProperty = p.Id,
                ListPrice = p.Financial.ListPrice,
                MonthlyRent = p.Financial.MonthlyRent,
                YearBuilt = 1992
            }
            ).ToList();
            return properties;
        }
    }
}
