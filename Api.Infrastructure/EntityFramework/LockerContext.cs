using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Infrastructure.EntityFramework
{
    public class LockerContext : DbContext
    {
        public LockerContext() : base("name=LockerConnection")
        {
        }
    }
}
