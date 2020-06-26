using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avangers.App.MVC.Models
{
    public interface IPersonRepository
    {
        IAsyncEnumerable<Person> GetAll();
    }
}
