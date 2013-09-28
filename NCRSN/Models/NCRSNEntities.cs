using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace NCRSN.Models
{
    public class NCRSNEntities: DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }

        public DbSet<Events> Events { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<EventLikesDislikes> EventLikesDislikes { get; set; }

        public DbSet<ClubSubscribe> ClubSubscribe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clubs>().ToTable("Clubs");
            modelBuilder.Entity<Events>().ToTable("Events");
            modelBuilder.Entity<Comments>().ToTable("Comments");
            modelBuilder.Entity<EventLikesDislikes>().ToTable("EventLikesDislikes");
            modelBuilder.Entity<ClubSubscribe>().ToTable("ClubSubscribe");

            base.OnModelCreating(modelBuilder);
        }
    }
}