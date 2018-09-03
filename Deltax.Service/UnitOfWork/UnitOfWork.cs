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
        private ActorRepository actors;
        public ActorRepository Actors
        {
            get {
                return new ActorRepository(context);
            }
        }
        // for movies

        //private GenericRepository<Movie> movies;
        public MovieRepository Movies
        {
            get
            {
                return new MovieRepository(context);
            }
        }
        //  for producer
        public ProducerRepository Producers
        {
            get
            {
                return new ProducerRepository(context);
            }
        }
        //private GenericRepository<Producer> producer;
        //public GenericRepository<Producer> Producer
        //{
        //    get
        //    {
        //        return new GenericRepository<Producer>(context);
        //    }
        //}

        //

        //private GenericRepository<User> users;
        //public GenericRepository<User> Users
        //{
        //    get
        //    {
        //        return new GenericRepository<User>(context);
        //    }
        //}

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
