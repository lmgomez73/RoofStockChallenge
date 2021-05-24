using AutoMapper;
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
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        //public List<>
        public PropertyService(ILogger<PropertyService> logger, RoofStockDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
            this._logger = logger;
        }

        public List<PropertyDTO> GetProperties()
        {
            List<PropertyDTO> properties = new List<PropertyDTO>();
            var p = _context.Property.Include(x => x.Physical).ToList();
            properties = _mapper.Map<List<PropertyDTO>>(_context.Property.Include(x => x.Address).Include(x => x.Financial).Include(x => x.Physical));
            //    .Select(p => new PropertyDTO {
            //    Address = p.Address.Address1  + " "+p.Address.City + ", "+ p.Address.State +" " +p.Address.Zip,
            //    GrossYield = (double)p.Financial.MonthlyRent * 12 * 100 / p.Financial.ListPrice,
            //    IdProperty = p.Id,
            //    ListPrice = p.Financial.ListPrice,
            //    MonthlyRent = p.Financial.MonthlyRent,
            //    YearBuilt = p.Physical == null ? null : p.Physical.YearBuilt
            //}
            //).ToList();
            return properties;
        }

        public void UpdateProperty(PropertyDTO dto, int id)
        {
            var property = _mapper.Map<Property>(dto);
            var address=_context.Address.First(x => x.IdProperty == property.Id);
            address.State = property.Address.State;
            address.Zip = property.Address.Zip;
            address.Address1 = property.Address.Address1;
            address.City = property.Address.City;


            var financial = _context.Financial.First(x => x.IdProperty == property.Id);
            financial.ListPrice = property.Financial.ListPrice;
            financial.MonthlyRent = property.Financial.MonthlyRent;

            var physical = _context.Physical.First(x => x.IdProperty == property.Id);
            physical.YearBuilt = property.Physical.YearBuilt;

            _context.SaveChanges();
        }
        public void AddProperty(PropertyDTO dto)
        {
            var property = _mapper.Map<Property>(dto);
            _context.Attach(property).State = EntityState.Added;
            _context.SaveChanges();
        }
    }
}
