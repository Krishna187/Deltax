using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Deltax.Entity.Domain;
using Deltax.Service.Interface;
using Deltax.Service.Repository;

namespace Deltax.Service.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private CastingContext context = new CastingContext();
        // for actor 
        private GenericRepository<Actor> actors;
        public GenericRepository<Actor> Actors
        {
            get {
                return new GenericRepository<Actor>(context);
            }
        }
        // for movies

        private GenericRepository<Movie> movies;
        public GenericRepository<Movie> Movies
        {
            get
            {
                return new GenericRepository<Movie>(context);
            }
        }
        //  for producer
        private GenericRepository<Producer> producer;
        public GenericRepository<Producer> Producer
        {
            get
            {
                return new GenericRepository<Producer>(context);
            }
        }

        //

        private GenericRepository<User> users;
        public GenericRepository<User> Users
        {
            get
            {
                return new GenericRepository<User>(context);
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
