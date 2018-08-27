namespace Deltax.Entity.Migrations
{
    using Deltax.Entity.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Deltax.Entity.Domain.CastingContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Deltax.Entity.Domain.CastingContext context)
        {
            var movie = new Movie
            {
                Actors = {
                    new Actor
                        {
                            User = new User
                            {
                                Name = "pradeep",
                                Dob = new DateTime(1992, 3, 20),
                                Bio = "he is a good guy",
                                Sex = Constants.Gender.Male
                            },
                        },
                    new Actor
                        {
                            User = new User
                            {
                                Name = "Amiya",
                                Dob = new DateTime(1989, 10, 20),
                                Bio = "he is a good guy",
                                Sex = Constants.Gender.Male
                            },
                        }
                    },

                Plot = "Based on Action",
                Producer = new Producer
                {
                    User = new User
                    {
                        Name = "Amit",
                        Dob = new DateTime(1990, 3, 20),
                        Bio = "he is a good guy",
                        Sex = Constants.Gender.Male
                    },
                },
                YearOfRelease = 1992,
            };

            context.Movies.Add(movie);
            context.SaveChanges();


            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            }
    }
    }
