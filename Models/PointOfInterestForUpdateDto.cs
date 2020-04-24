﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Models
{
    public class PointOfInterestForUpdateDto
    {
        // same as the creation model class
        [Required(ErrorMessage = "You should provide a name value.")] // these are data annnotations for validations
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
