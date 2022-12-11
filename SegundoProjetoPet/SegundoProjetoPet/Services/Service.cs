using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;

namespace SegundoProjetoPet.Services
{
    public abstract class Service<T, U> where T : Person where U : Repository<T>
    {
        private Repository<T> Repository { get; }

        public Service(Repository<T> repository)
        {
            this.Repository = repository;
        }

        public T Add(T element)
        {
            return Repository.Add(element);
        }

        public bool Remove(int id)
        {
            return Repository.Remove(id);
        }

        public T? Update(T element)
        {
            T? member = this.Get(element.Id);
            if(member == null)
            {
                return null;
            }
            return this.Repository.Update(element);
        }

        public T? Get(int id)
        {
            return Repository.Get(id);
        }

        public List<T> Register()
        {
            return Repository.Register();
        }
    }
}