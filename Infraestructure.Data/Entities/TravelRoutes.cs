using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Infraestructure.Data.Entities
{
    public class TravelRoutes
    {
        public int Id { get; set; }

        [Required]
        public DateTime DepartureDate { get; set; } 
        
        [Required]
        public int TransportationType { get; set; }

        [Required]
        public int Disponibility { get; set; }

        [Required]
        public string Departure { get; set; }

        [Required]
        public string Arrival { get; set; }
        public string OwnerEmployee { get; set; }

        public bool IsCanceled { get; set; }

    }
}
