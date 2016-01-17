namespace Server
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Shujuku : DbContext
    {
        public Shujuku()
            : base("name=Shujuku")
        {
        }

        public virtual DbSet<Table.Yonghu> Yonghu { get; set; }
    }

   
}