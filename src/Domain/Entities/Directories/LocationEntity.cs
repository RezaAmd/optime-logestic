using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Directories
{
    public class LocationEntity : BaseEntity
    {
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}