﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    public class NewClass
    {
        public string Name
        {
            get;
            set;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void DoSomething()
        {
            //здесь что-то непроисходит
        }

        public void DoSomething1()
        {
            //здесь что-то происходит
        }

    }
}
