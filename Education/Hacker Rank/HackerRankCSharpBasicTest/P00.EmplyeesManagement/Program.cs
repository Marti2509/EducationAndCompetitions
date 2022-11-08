using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Solution
{
    public class Solution
    {

        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, List<Employee>> companies = new Dictionary<string, List<Employee>>();

            foreach (var person in employees)
            {
                if (!companies.ContainsKey(person.Company))
                {
                    companies[person.Company] = new List<Employee>();
                }

                companies[person.Company].Add(person);
            }

            SortedDictionary<string, int> result = new SortedDictionary<string, int>();

            foreach (var company in companies)
            {
                decimal ageSum = 0;
                decimal count = 0;

                foreach (var person in company.Value)
                {
                    ageSum += person.Age;
                    count++;
                }

                result[company.Key] = (int)Math.Round((ageSum / count), 0);
            }

            Dictionary<string, int> result2 = new Dictionary<string, int>();

            foreach (var company in result)
            {
                result2[company.Key] = company.Value;
            }

            return result2;
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            Dictionary<string, List<Employee>> companies = new Dictionary<string, List<Employee>>();

            foreach (var person in employees)
            {
                if (!companies.ContainsKey(person.Company))
                {
                    companies[person.Company] = new List<Employee>();
                }

                companies[person.Company].Add(person);
            }

            SortedDictionary<string, int> result = new SortedDictionary<string, int>();

            foreach (var company in companies)
            {
                result[company.Key] = company.Value.Count;
            }

            Dictionary<string, int> result2 = new Dictionary<string, int>();

            foreach (var company in result)
            {
                result2[company.Key] = company.Value;
            }

            return result2;
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            Dictionary<string, List<Employee>> companies = new Dictionary<string, List<Employee>>();

            foreach (var person in employees)
            {
                if (!companies.ContainsKey(person.Company))
                {
                    companies[person.Company] = new List<Employee>();
                }

                companies[person.Company].Add(person);
            }

            SortedDictionary<string, Employee> result = new SortedDictionary<string, Employee>();

            foreach (var company in companies)
            {
                Employee employee = new Employee();
                int age = 0;

                foreach (var person in company.Value)
                {
                    if (person.Age > age)
                    {
                        age = person.Age;
                        employee = person;
                    }
                }

                result[company.Key] = employee;
            }

            Dictionary<string, Employee> result2 = new Dictionary<string, Employee>();

            foreach (var company in result)
            {
                result2[company.Key] = company.Value;
            }

            return result2;
        }

        public static void Main()
        {

            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
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