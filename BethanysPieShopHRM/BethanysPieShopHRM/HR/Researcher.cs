using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Researcher : Employee
    {
        private int numberOfPiesInvented = 0;

        public int NumberOfPiesInvented
        {
            get { return numberOfPiesInvented; }
            private set 
            { 
                numberOfPiesInvented = value; 
            }
        }
        public Researcher(string firstName, string lastName, string email, DateTime birthday, double? hourlyWage) : base(firstName, lastName, email, birthday, hourlyWage)
        {

        }

        public void ResearchNewPieTastes(int researchHours)
        {
            NumberOfHoursWorked += researchHours;

            if(new Random().Next(100) > 50)
            {
                numberOfPiesInvented++;

                Console.WriteLine($"Researcher {FirstName} {LastName} has invented a new pie taste! Total number of pies invented: {NumberOfPiesInvented}");
            }
            else
            {
                Console.WriteLine($"Researcher {FirstName} {LastName} is still working on a new pie taste!");
            }
        }
    }
}
