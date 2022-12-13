using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Argos.Services.DTO
{
    public class TravelRoutesDto
    {
        public int Id { get; set; }        
        public DateTime DepartureDate { get; set; }        
        public int TransportationType { get; set; }        
        public int Disponibility { get; set; }        
        public string Departure { get; set; }        
        public string Arrival { get; set; }
        public string OwnerEmployee { get; set; }
        public bool IsCanceled { get; set; }
    }
}
