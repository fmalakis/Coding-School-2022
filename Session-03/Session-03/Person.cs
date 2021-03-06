using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Person
    {
        public Guid Id { get; }
        public string Name;
        public ushort Age { get; set; }

        public Person(string _name, ushort _age)
        {
            Id = Guid.NewGuid();
            Name = _name;
            Age = _age;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string _name)
        {
            Name = _name;
        }

    }
}
