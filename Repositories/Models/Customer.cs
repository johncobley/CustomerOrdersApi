using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class Customer
    {
        private static int NextId = 0;

        public Customer()
        {
            Id = NextId++;
        }

        public int Id { get; private set; }
        public string Name { get; set; }
    }
}
