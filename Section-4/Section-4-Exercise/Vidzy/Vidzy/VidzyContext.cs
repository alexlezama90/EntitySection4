using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vidzy.Model;

namespace Vidzy
{
    public class VidzyContext : DbContext
    {
        public VidzyContext()
            :base("name=VidzyContext")
        {
        }

        public virtual DbSet<Video> Videos { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }

    }
}
