using System;
using System.Collections.Generic;

namespace DAL {
    public class Something {}
    public interface ISomethingRepository : IDisposable
    {
        IEnumerable<Something> GetSomethings();
        Something GetSomethingByID(long id);
        void InsertSomething(Something something);
        void DeleteSomething(long id);
        void UpdateSomething(Something something);
        void Save();
    }

    public interface IRepository<T> : IDisposable 
    {
        IEnumerable<T> Get();
        T GetByID(long id);
        void Insert(T item);
        void Delete(long id);
        void Update(T item);
        void Save();
    }
    public class Item {}

    public class Repository<T> :  IRepository<T> where T : new()
    {
        public IEnumerable<T> Get() {
            return new List<T>();
        }
        public T GetByID(long id) {
            return new T();
        }

        public void Insert(T item) {

        }
        public void Delete(long id) {

        }
        public void Update(T item){

        }
        public void Save() {

        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                   //
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