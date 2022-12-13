using Argos.Services.DTO;
using Argos.Services.Interfaces;
using Infraestructure.Data.Context;
using Infraestructure.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Argos.Services.Services
{
    public class TravelRouteService : ITravelRoutesService
    {
        #region Constructor

        private ArgosDbContext _context;
        public TravelRouteService(ArgosDbContext context)
        {
            _context = context;
        }

        #endregion
        public List<TravelRoutesDto> GetAll()
        {
            var query = (from e in _context.TravelRoutes
                         select new TravelRoutesDto()
                         {
                             Arrival = e.Arrival,
                             Departure = e.Departure,
                             DepartureDate = e.DepartureDate,
                             Disponibility = e.Disponibility,
                             Id = e.Id,
                             IsCanceled = e.IsCanceled,
                             OwnerEmployee = e.OwnerEmployee,
                             TransportationType = e.TransportationType,
                         }).ToList();
            return query;
        }

        public bool SaveRoute(TravelRoutesDto route)
        {
            try
            {
                TravelRoutes travelrouteSave = new TravelRoutes();
                travelrouteSave.IsCanceled = route.IsCanceled;
                travelrouteSave.Arrival = route.Arrival;
                travelrouteSave.TransportationType = route.TransportationType;
                travelrouteSave.DepartureDate = route.DepartureDate;
                travelrouteSave.Departure = route.Departure;
                travelrouteSave.Disponibility = route.Disponibility;
                travelrouteSave.OwnerEmployee = route.OwnerEmployee;
                _context.TravelRoutes.Add(travelrouteSave);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateRoute(TravelRoutesDto route)
        {
            try
            {
                var travelrouteSave = (from e in _context.TravelRoutes
                                       where e.Id == route.Id
                                       select e).FirstOrDefault();

                if (travelrouteSave != null)
                {

                    travelrouteSave.IsCanceled = route.IsCanceled;
                    travelrouteSave.Arrival = route.Arrival;
                    travelrouteSave.TransportationType = route.TransportationType;
                    travelrouteSave.DepartureDate = route.DepartureDate;
                    travelrouteSave.Departure = route.Departure;
                    travelrouteSave.Disponibility = route.Disponibility;
                    travelrouteSave.OwnerEmployee = route.OwnerEmployee;
                }
                _context.Entry(travelrouteSave).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
