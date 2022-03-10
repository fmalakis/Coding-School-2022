﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityLogic
{
    internal class Institute
    {
        public Guid ID { get; }
        public string Name { get; set; }
        public int YearsInService { get; set; }

        public Institute(string _Name, int _YearsInService)
        {
            ID = Guid.NewGuid();
            Name = _Name;
            YearsInService = _YearsInService;
        }



    }
}
