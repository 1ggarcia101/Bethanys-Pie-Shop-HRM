using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    public class Employee: IEmployee
    {
        #region fields
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double? hourlyWage; //nullable value type

        private DateTime birthday;
        private const int minimalHoursWorkedUnit = 1;

        private Address address;

        private static double taxRate = 0.15;
        #endregion

        #region properties
        public string FirstName
        {
            get
            { 
                return firstName; 
            }
            set 
            { 
                firstName = value; 
            }
        }

        public string LastName { get { return lastName; } set { lastName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public int NumberOfHoursWorked 
        { 
            get { return numberOfHoursWorked; } 
            protected set 
            { 
                numberOfHoursWorked = value; 
            } 
        }
        public double Wage 
        { 
            get { return wage; } 
            set 
            { 
                wage = value; 
            } 
        }

        public double? HourlyWage
        {
            get { return hourlyWage; }
            set
            {
                if (hourlyWage < 0)
                {
                    hourlyWage = 0;
                }
                else
                {
                    hourlyWage = value;
                }
            }
        }


        public DateTime BirthDay
        {
            get { return birthday; } 
            set { birthday = value; }
        }

        public Address Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }

        #endregion

        #region constructors
        public Employee(string firstName, string lastName, string email, DateTime birthday) : this(firstName, lastName, email, birthday, 0)
        {

        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, double? hourlyWage)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyWage = hourlyWage ?? 10;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, double? hourlyWage, string street, string houseNumber, string zip, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            BirthDay = birthday;
            HourlyWage = hourlyWage ?? 10;

            Address = new Address(street, houseNumber, zip, city);
        }
        #endregion

        #region methods
        public void PerformWork()
        {
            //numberOfHoursWorked++;
            PerformWork(minimalHoursWorkedUnit);
            //Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHoursWorked} hour(s)!");
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} {LastName} has worked for {numberOfHours} hours(s)!");
        }

        public int CalculatedBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }

        public int CalculatedBonusAndBonusTax(int bonus, ref int bonusTax)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;
            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the tax on the bonus is {bonusTax}");
            return bonus;
        }

        public virtual void GiveBonus()
        {
            Console.WriteLine($"{FirstName} ({LastName}) received a generic bonus of 100!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyWage.Value;
            double taxAmount = wageBeforeTax * taxRate;

            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} {LastName} has received a wage of {Wage} for {NumberOfHoursWorked} hour(s) of work.");

            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: \t{FirstName}\nLast name: \t{LastName}\nEmail: \t\t{Email}\nBirthday: \t{BirthDay.ToShortDateString()}\nTax rate: \t{taxRate}\n");
        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You did a great job, {FirstName}");
        }
        #endregion
    }
}
