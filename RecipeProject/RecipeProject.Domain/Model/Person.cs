﻿using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeProject.Domain.Model
{
    public abstract class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

    }
}
