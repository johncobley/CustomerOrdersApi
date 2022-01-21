using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositories.Models
{
    public class Customer
    {
        private static int NextId = 0;
        private int _id;

        public Customer()
        {
            _id = NextId++;
        }

        public int Id { get => _id; }
        public string Name { get; set; }
    }
}
