using RoofstockChallenge.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoofstockChallenge.Business
{
    public interface IPropertyService
    {
        List<PropertyDTO> GetProperties();
    }
}
