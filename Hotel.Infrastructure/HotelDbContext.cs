using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hotel.Domain.Model;


namespace Hotel.Infrastructure
{
    internal class HotelDBContext: DbContext
    {
        public HotelDBContext(DbContextOptions<HotelDBContext> options) : base(options)
        {
        }
        public DbSet<Hotel1> Hotels { get; set; }
        
    }
    
    
}
