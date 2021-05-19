using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoofstockChallenge.Model.DTO
{
    public class PropertyDTO
    {
        public string Address { get; set; }
        public int YearBuilt { get; set; }
        public double? ListPrice { get; set; }
        public double? MonthlyRent { get; set; }
        public double? GrossYield { get; set; }
        public int IdProperty { get; set; }
    }
}
