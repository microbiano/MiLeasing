using MiLeasing.Web.Data.Entities;
using System.Collections.Generic;

namespace MiLeasing.Web.Data.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        public User User { get; set; }

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
