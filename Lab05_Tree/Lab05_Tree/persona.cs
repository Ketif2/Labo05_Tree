﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Tree
{
    public class Person
    {

        /* Getters and Setters */
        public int Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        //public Person() { }
        public Person(int id, string name, string role)
        {
            Id = id;
            Name = name;
            Role = role;
        }


    }
}
