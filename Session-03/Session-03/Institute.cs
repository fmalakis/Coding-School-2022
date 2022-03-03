﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Institute
    {
        private Guid ID { get; }
        private string Name;
        private ushort YearsInService { get; }

        public Institute(string _name, ushort _yearsInService)
        {
            Name = _name;
            YearsInService = _yearsInService;
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
