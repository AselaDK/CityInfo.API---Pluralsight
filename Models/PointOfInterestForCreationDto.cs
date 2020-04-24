using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    // id of interest should not be exposed. so this resourse is created
    public class PointOfInterestForCreationDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
