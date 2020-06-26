using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Avangers.App.MVC.Models
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AvengersContext ctx;

        public PersonRepository(AvengersContext ctx)
        {
            this.ctx = ctx;
        }
        IAsyncEnumerable<Person> IPersonRepository.GetAll()
        {
            return ctx.Persons;
        }
    }
}
