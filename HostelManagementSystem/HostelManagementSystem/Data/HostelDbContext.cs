using HostelManagementSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Data
{
    public class HostelDbContext:DbContext
    {
        public HostelDbContext(DbContextOptions<HostelDbContext> options) : base(options)
        {

        }
        public DbSet<Admission> Admission { get; set; }
        public DbSet<RoomDetails> RoomDetails { get; set; }
        public DbSet<RoomAllocation> RoomAllocation { get; set; }
    }
}
