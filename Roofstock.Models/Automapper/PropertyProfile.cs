using AutoMapper;
using Microsoft.Extensions.Logging;
using RoofstockChallenge.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoofstockChallenge.Model.Automapper
{
    public class PropertyProfile : Profile
    {
        private readonly ILogger<PropertyProfile> _logger;

        public PropertyProfile(ILogger<PropertyProfile> logger)
        {
            CreateMap<Property, PropertyDTO>()
                .ForMember(x => x.Address, opt => opt.MapFrom(source => source.Address.Address1 + ", " + source.Address.City + ", " + source.Address.State + ", " + source.Address.Zip))
                .ForMember(x => x.GrossYield, opt => opt.MapFrom(source => (double)source.Financial.MonthlyRent * 12 * 100 / source.Financial.ListPrice))
                .ForMember(x => x.IdProperty, opt => opt.MapFrom(source => source.Id))
                .ForMember(x => x.ListPrice, opt => opt.MapFrom(source => source.Financial.ListPrice))
                .ForMember(x => x.MonthlyRent, opt => opt.MapFrom(source => source.Financial.MonthlyRent))
                .ForMember(x => x.YearBuilt, opt => opt.MapFrom(source => source.Physical.YearBuilt));

            CreateMap<PropertyDTO, Property>()
                .ForMember(x => x.Address, opt => opt.MapFrom(source => MapStringToAddress(source.Address, source.IdProperty)))
                .ForMember(x => x.Id, opt => opt.MapFrom(source => source.IdProperty))
                .ForMember(x => x.Financial, opt => opt.MapFrom(source => new Financial
                {
                    IdProperty = source.IdProperty,
                    ListPrice = source.ListPrice,
                    MonthlyRent = source.MonthlyRent
                }))
                .ForMember(x => x.Physical, opt => opt.MapFrom(source => new Physical
                {
                    IdProperty = source.IdProperty,
                    YearBuilt = source.YearBuilt
                }));
            this._logger = logger;
        }
        private Address MapStringToAddress(string addressString, int idProperty)
        {
            try
            {
                var split = addressString.Split(',');
                int count = split.Length;
                Address result = new Address();
                result.IdProperty = idProperty;
                result.Address1 = split[0].Trim();
                result.City = count > 0 ? split[1].Trim() : null;
                result.State = count > 1 ? split[2].Trim() : null;
                result.Zip = count > 2 ? split[3].Trim() : null;
                return result;
            }
            catch (Exception)
            {
                _logger.LogError("Error parsing Address for property {0}", idProperty);
                return null;
            }

        }
    }

}
