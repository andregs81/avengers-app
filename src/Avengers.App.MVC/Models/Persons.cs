using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avangers.App.MVC.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        public string SecretIdentity { get; set; }
        public int YearOfCreation { get; set; }
        public string Icon { get; set; }

        public string GetIcon()
        {
            return string.IsNullOrEmpty(Icon) ? "no-photo.png" : Icon;
        }
    }
}
