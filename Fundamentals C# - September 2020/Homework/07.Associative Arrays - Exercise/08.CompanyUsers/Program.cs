using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();
            string[] input = Console.ReadLine().Split(" -> ");

            while (input[0] != "End")
            {
                string companyName = input[0];
                string employeeName = input[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string> { employeeName });
                }
                else
                {
                    if (!companies[companyName].Contains(employeeName))
                    {
                        companies[companyName].Add(employeeName);
                    }
                }
                input = Console.ReadLine().Split(" -> ");
            }

            foreach (var company in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);

                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}