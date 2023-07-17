using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        #region manager constructor
        public Manager(string firstName, string lastName, string email, DateTime birthday, double? hourlyWage) : base(firstName, lastName, email, birthday, hourlyWage)
        {

        }
        #endregion

        #region manager methods
        public void AttendManagementMeeting()
        {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} {LastName} is now attending a meeting!");
        }

        public override void GiveBonus()
        {
            if ( NumberOfHoursWorked > 5 )
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 500!");
            }
            else
            {
                Console.WriteLine($"Manager {FirstName} {LastName} received a management bonus of 250!");
            }
        }

        #endregion
    }
}
