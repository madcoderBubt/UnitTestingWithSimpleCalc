using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleCalc
{
    public class Solution
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> avgByCompany = new Dictionary<string, int>();
            avgByCompany = employees.GroupBy((x) => x.Company).Select(grp =>
            new {
                key = grp.Key,
                val = Convert.ToInt32(grp.Average(e=>e.Age))
            }).ToDictionary(k=>k.key, e=>e.val);
            return avgByCompany;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, int> avgByCompany = new Dictionary<string, int>();
            avgByCompany = employees.GroupBy((x) => x.Company).Select(grp =>
             new {
                 key = grp.FirstOrDefault().Company,
                 val = Convert.ToInt32(grp.Count())
             }).ToDictionary(k=>k.key, v=>v.val);
            return avgByCompany;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, Employee> avgByCompany = new Dictionary<string, Employee>();
            avgByCompany = employees.GroupBy((x) => x.Company).Select(grp =>
             new {
                 key = grp.FirstOrDefault().Company,
                 val = grp.OrderByDescending(e => e.Age).FirstOrDefault()
                }).ToDictionary(k=>k.key, v=>v.val);
            return avgByCompany;
        }
}

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}   