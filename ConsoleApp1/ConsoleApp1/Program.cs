using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the employee's name here:");
            string employees_name = Console.ReadLine();
            Console.WriteLine("Please enter here the number of hours the employee worked:");
            float the_umber_of_hours_the_employee_worked = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the employee's hourly rate in USD here:");
            float hourly_rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the employee's age here:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the employee a citizen (C) or not (F)? Enter your answer here please:");
            char status = char.Parse(Console.ReadLine());
            if (age >= 0 && age < 17)
            {
                if (the_umber_of_hours_the_employee_worked - 5 >= 0)
                {
                    float the_umber_of_hours_the_employee_worked_sv = (the_umber_of_hours_the_employee_worked - 5);
                    if (status == 'C')
                    {
                        float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked_sv;
                        salary_of_the_employee = salary_of_the_employee - 0.3f * salary_of_the_employee;
                        Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                    }
                    else if (status == 'F')
                    {
                        float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked_sv;
                        Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong");
                    }
                }
                else
                {
                    int the_umber_of_hours_the_employee_worked_sv = 0;
                    float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked_sv;
                    Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                }
            }
            else if (age > 50)
            {
                hourly_rate += 5;
                float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked;
                if (status == 'C')
                {
                    salary_of_the_employee = salary_of_the_employee - 0.3f * salary_of_the_employee;
                    Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                }
                else if (status == 'F')
                {
                    Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                }
            }
            else if (age >= 17 && age <= 50)
            {
                if (status == 'C')
                {
                    float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked;
                    salary_of_the_employee = salary_of_the_employee - 0.3f * salary_of_the_employee;
                    Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                }
                else if (status == 'F')
                {
                    float salary_of_the_employee = hourly_rate * the_umber_of_hours_the_employee_worked;
                    Console.WriteLine(employees_name + ":" + salary_of_the_employee + "$");
                }
            }
            else if (age < 0)
            {
                Console.WriteLine("Something went wrong");
            }
            Console.ReadKey();
        }
    }
}