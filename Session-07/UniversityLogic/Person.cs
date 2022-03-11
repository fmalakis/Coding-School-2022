using System;

namespace UniversityLogic
{
    public class Person
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string _Name, int _Age)
        {
            ID = Guid.NewGuid();
            Name = _Name;
            Age = _Age;
        }

    }
}