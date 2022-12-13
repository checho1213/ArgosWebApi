using Infraestructure.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure.Data.Context
{
    public class ArgosDbContext : DbContext
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="DataBaseContext" /> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public ArgosDbContext(DbContextOptions<ArgosDbContext> options)
            : base(options)
        { }

        /// <summary>
        /// Gets or sets the TravelRoutes.
        /// </summary>
        /// <value>The TravelRoutes.</value>
        public DbSet<TravelRoutes> TravelRoutes { get; set; }

        

    }
}
