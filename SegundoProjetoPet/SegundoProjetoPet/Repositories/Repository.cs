using SegundoProjetoPet.Models;

namespace SegundoProjetoPet.Repositories
{
    public abstract class Repository<T> where T : Person {

        private readonly DataContext data;

        public Repository()
        {
            var config = new ConfigurationBuilder().
                AddJsonFile(
                    Path.
                        Combine(
                            AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"
                            )
                    ).Build();
            data = new DataContext(config);
        }

        public T Add(T element)
        {
            this.data.Set<T>().Add(element);
            this.data.SaveChanges();
            return element;
        }

        public bool Remove(int id) 
        {
            T? rem = this.Get(id);
            if ( rem == null ) 
            {
                return false;
            }
            this.data.Set<T>().Remove(rem); 
            this.data.SaveChanges();
            return true;
        }

        public T? Update(T element)
        {
            T? up = Get(element.Id);
            if (up == null)
            {
                return null;
            }
            var infos = element.GetType().GetProperties();
            foreach (var info in infos)
            {
                info.SetValue(up, info.GetValue(element));
            }
            up = this.data.Set<T>().Update(up).Entity;
            this.data.SaveChanges();
            return up;
        }

        public T? Get(int id)
        {
            return this.data.Set<T>().Where(e => e.Id == id).FirstOrDefault();
        }

        public List<T> Register()
        {
            return this.data.Set<T>().ToList();
        }
    }
}