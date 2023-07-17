using BethanysPieShopHRM.HR;

#region Employee Object instantiated from Employee Class
//Console.WriteLine("Creating an employee");
//Console.WriteLine("-----------------\n");

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);

//bethany.PerformWork(25);

//int minimumBonus = 100;
//int receivedBonus = bethany.CalculatedBonus(minimumBonus);
//Console.WriteLine($"The minimum bonus is {minimumBonus} and {bethany.firstName} has received a bonus of {receivedBonus}");

//int minimumBonus = 100;
//int bonusTax = 0;
//int receivedBonus = bethany.CalculatedBonusAndBonusTax(minimumBonus, ref bonusTax);
//Console.WriteLine($"The minimum bonus is {minimumBonus}, the bonus tax is {bonusTax} and {bethany.firstName} has received a bonus of {receivedBonus}");

//#region First run Bethany
//bethany.DisplayEmployeeDetails();

//bethany.PerformWork();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//#endregion

//double receivedWageBethany = bethany.ReceiveWage(true);
//Console.WriteLine($"Wage paid (message from Program): {receivedWageBethany}");

//Console.WriteLine("Creating an employee");
//Console.WriteLine("-----------------\n");

//Employee george = new("George", "Jones", "george@snowball.be", new DateTime(1984, 3, 28), 30, EmployeeType.Research);

//george.DisplayEmployeeDetails();
//george.PerformWork();
//george.PerformWork(5);
//george.PerformWork(6);
//george.PerformWork(7);
//george.PerformWork(8);

//var receivedWageGeorge = george.ReceiveWage(true);

//BethanysPieShopHRM.Accounting.Customer customer = new BethanysPieShopHRM.Accounting.Customer();

//WorkTask task;
//task.description = "Bake delicious pies";
//task.hours = 3;
//task.PerformWorkTask();

//string name = "bethany";
//string anotherName = name;
//name += " smith";

//Console.WriteLine("name: " + name);
//Console.WriteLine("another name: " + anotherName);

//int[] sampleArray1 = new int[5];

//int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };
#endregion



#region employee array for loop and various array methods

//Console.WriteLine("How many employes IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//int[] employeeIds = new int[length];

//var testId = employeeIds[0];


//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIds[i] = id;
//}

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Array.Sort(employeeIds);

//Console.WriteLine("After sorting");
//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//int[] employeeIdsCopy = new int[length];

//employeeIds.CopyTo(employeeIdsCopy, 0);

//Array.Reverse(employeeIds);

//Console.WriteLine("After reversing original array");

//for (int i = 0;i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIds[i]}");
//}

//Console.WriteLine("Copy of array");

//for (int i = 0; i < employeeIds.Length; i++)
//{
//    Console.WriteLine($"ID {i + 1}: \t{employeeIdsCopy[i]}");
//}

#endregion


#region employee array for each
//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1954, 9, 23), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jafng", "mary@snowball.be", new DateTime(1997, 12, 16), 38, EmployeeType.Sales);
//Employee bob = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1923, 7, 16), 26, EmployeeType.Manager);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1978, 3, 16), 14, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1964, 2, 16), 40, EmployeeType.Research);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1986, 6, 16), 21, EmployeeType.Manager);

//Employee[] employees = new Employee[7];
//employees[0] = bethany;
//employees[1] = george;
//employees[2] = mary;
//employees[3] = bob;
//employees[4] = kevin;
//employees[5] = kate;
//employees[6] = kim;

//foreach(Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//    var numberOfHoursWorked = new Random().Next(25);
//    e.PerformWork(numberOfHoursWorked);
//    e.ReceiveWage();
//}
#endregion


#region employee List

//List<int> employeeIdsList = new List<int>();

//employeeIdsList.Add(55);
//employeeIdsList.Add(1);
//employeeIdsList.Add(36);
//employeeIdsList.Add(418);
//employeeIdsList.Add(7896);

//if (employeeIdsList.Contains(36))
//{
//    Console.WriteLine("36 is found!");
//}

//int currentAmountOfEmployees = employeeIdsList.Count;

//var employeeIdsArray = employeeIdsList.ToArray();

//employeeIdsList.Clear();


//Console.WriteLine("How many employes IDs do you want to register?");

//int length = int.Parse(Console.ReadLine());

//for (int i = 0; i < length; i++)
//{
//    Console.WriteLine("Enter the employee ID: ");
//    int id = int.Parse(Console.ReadLine());
//    employeeIdsList.Add(id);
//}

//Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25, EmployeeType.Manager);
//Employee george = new Employee("George", "Jones", "george@snowball.be", new DateTime(1954, 9, 23), 30, EmployeeType.Research);
//Employee mary = new Employee("Mary", "Jafng", "mary@snowball.be", new DateTime(1997, 12, 16), 38, EmployeeType.Sales);
//Employee bob = new Employee("Bob", "Spencer", "bob@snowball.be", new DateTime(1923, 7, 16), 26, EmployeeType.Manager);
//Employee kevin = new Employee("Kevin", "Marks", "kevin@snowball.be", new DateTime(1978, 3, 16), 14, EmployeeType.StoreManager);
//Employee kate = new Employee("Kate", "Greggs", "kate@snowball.be", new DateTime(1964, 2, 16), 40, EmployeeType.Research);
//Employee kim = new Employee("Kim", "Jacobs", "kim@snowball.be", new DateTime(1986, 6, 16), 21, EmployeeType.Manager);

//List<Employee> employees = new List<Employee>();
//employees.Add(george);
//employees.Add(mary);
//employees.Add(bob);
//employees.Add(kevin);
//employees.Add(kim);
//employees.Add(kate);

//foreach (Employee e in employees)
//{
//    e.DisplayEmployeeDetails();
//}

#endregion


#region properties

IEmployee bethany = new StoreManager("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), 25);
IEmployee mary = new Manager("Mary", "Jones", "mary@snowball.be", new DateTime(1965, 1, 16), 30);
IEmployee bob = new JuniorResearcher("Bob", "Spencer", "bob@snowball.be", new DateTime(1988, 1, 23), 17);
IEmployee jake = new Employee("Jake", "Nicols", "jake@snowball.be", new DateTime(1995, 8, 16), 25, "Cactus street", "123", "85032", "Phoenix");
IEmployee kate = new StoreManager("Kate", "Greggs", "kate@snowball.be", new DateTime(1993, 8, 8), 10);

List<IEmployee> employees = new List<IEmployee>();
employees.Add(bob);
employees.Add(jake);
employees.Add(kate);
employees.Add(bethany);
employees.Add(mary);

foreach (Employee employee in employees)
{
    employee.DisplayEmployeeDetails();
    employee.GiveBonus();
    employee.GiveCompliment();
}

//bethany.DisplayEmployeeDetails();
//bethany.PerformWork();
//bethany.PerformWork(5);
//bethany.PerformWork();
//bethany.ReceiveWage();

//mary.DisplayEmployeeDetails();
//mary.PerformWork(5);
//mary.PerformWork();
//mary.ReceiveWage();
//mary.AttendManagementMeeting();
//mary.GiveBonus();

//bob.ResearchNewPieTastes(5);
//bob.ResearchNewPieTastes(5);
//bob.ResearchNewPieTastes(6);



#endregion