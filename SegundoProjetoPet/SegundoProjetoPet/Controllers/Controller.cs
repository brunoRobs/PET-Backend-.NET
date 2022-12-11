using Microsoft.AspNetCore.Mvc;
using SegundoProjetoPet.Models;
using SegundoProjetoPet.Repositories;
using SegundoProjetoPet.Services;

namespace SegundoProjetoPet.Controllers
{
    [ApiController]
    public abstract class Controller<T, U, V> : ControllerBase where T : Person
        where U : Repository<T> where V : Service<T, U>
    {
        protected V Service { get; set; }
        
        [HttpPost]
        public IActionResult Add(T element)
        {
            return this.Ok(Service.Add(element));
        }

        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            if (Service.Remove(id))
            {
                return this.Ok(new Message(20, typeof(T).Name + " succesfully excluded!"));
            }
            return this.Ok(new Message(21, typeof(T).Name + " not found or already deleted."));
        }

        [HttpPut]
        public IActionResult Update(T element)
        {
            T? member = this.Service.Get(element.Id);
            if(member == null)
            {
                return this.Ok(new Message(22, typeof(T).Name + " not found."));
            }
            T up = Service.Update(element);
            return this.Ok(up);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            T? element = Service.Get(id);
            if(element == null)
            {
                return this.Ok(new Message(23, typeof(T).Name + " not found."));
            }
            return this.Ok(element);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.Ok(Service.Register());
        }
    }
}