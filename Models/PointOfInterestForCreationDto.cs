using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    // id of interest should not be exposed. so this resourse is created
    public class PointOfInterestForCreationDto
    {
        [Required(ErrorMessage = "You should provide a name value.")] // these are data annnotations for validations
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
