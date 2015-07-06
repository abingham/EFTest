using System;
using System.Data.Entity;

namespace EFTest
{
    public class SimpleContext : DbContext
    {
        public SimpleContext () : base("SimpleContext")
        {
            
        }

        public DbSet<Person> People { 
            get; 
            set;
        }
    }
}

