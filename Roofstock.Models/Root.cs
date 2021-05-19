using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoofstockChallenge.Model
{
    [NotMapped]
    public class Root
    {
        public List<Property> Properties { get; set; }
    }
}
