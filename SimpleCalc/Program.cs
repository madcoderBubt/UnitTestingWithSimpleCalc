using System;
using System.Collections.Generic;

namespace SimpleCalc
{
    class Program
    {
        public static void Main()
        {
            long x = RepeatedStringSolutions.RepeatedString("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq", 549382313570);
            Console.WriteLine(x);//16481469408 == 16481469405

            //int countOfEmployees = int.Parse(Console.ReadLine());

            //var employees = new List<Employee>();

            //for (int i = 0; i < countOfEmployees; i++)
            //{
            //    string str = Console.ReadLine();
            //    string[] strArr = str.Split(' ');
            //    employees.Add(new Employee
            //    {
            //        FirstName = strArr[0],
            //        LastName = strArr[1],
            //        Company = strArr[2],
            //        Age = int.Parse(strArr[3])
            //    });
            //}

            //foreach (var emp in Solution.AverageAgeForEachCompany(employees))
            //{
            //    Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            //}

            //foreach (var emp in Solution.CountOfEmployeesForEachCompany(employees))
            //{
            //    Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            //}

            //foreach (var emp in Solution.OldestAgeForEachCompany(employees))
            //{
            //    Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            //}

            Console.ReadKey();
        }
    }
}
