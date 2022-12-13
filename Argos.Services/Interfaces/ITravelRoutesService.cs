using Argos.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Argos.Services.Interfaces
{
    public interface ITravelRoutesService
    {
        /// <summary>
        /// Obtiene el listado de rutas
        /// </summary>
        /// <returns></returns>
        List<TravelRoutesDto> GetAll();

        /// <summary>
        /// Guardar rutas
        /// </summary>
        /// <returns></returns>
        bool SaveRoute(TravelRoutesDto route);
        
        /// <summary>
        /// Actualizar rutas
        /// </summary>
        /// <returns></returns>
        bool UpdateRoute(TravelRoutesDto route);
    }
}
