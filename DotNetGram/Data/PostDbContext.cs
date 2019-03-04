using DotNetGram.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetGram.Data
{
    public class PostDbContext:DbContext
    {
        public PostDbContext(DbContextOptions<PostDbContext> options) : base

           (options)

        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            modelBuilder.Entity<Post>().HasData(

                new Post
                {
                    ID = 1,
                    PosterName = "Anemone",
                    URL = ""
                },
                 new Post
                 {
                     ID = 2,
                     PosterName = "Cymbidium",
                     URL = ""
                 },
                  new Post
                  {
                      ID = 3,
                      PosterName = "Gerberas",
                      URL = ""
                  },
                   new Post
                   {
                       ID = 4,
                       PosterName = "Peonies",
                       URL = ""
                   },
                    new Post
                    {
                        ID = 5,
                        PosterName = "Violets",
                        URL = ""
                    });
        }
        public DbSet<Post> Posts { get; set; }


    }
}

    

