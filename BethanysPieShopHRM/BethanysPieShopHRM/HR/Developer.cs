﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Developer : Employee
    {
        private string currentProject;

        public string CurrentProject
        {
            get { return currentProject; }
            set 
            { 
                currentProject = value; 
            }
        }
        public Developer(string firstName, string lastName, string email, DateTime birthday, double? hourlyWage) : base(firstName, lastName, email, birthday, hourlyWage)
        {

        }
    }
}
