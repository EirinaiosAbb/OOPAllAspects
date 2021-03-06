﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAllAspects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Panos Bozas");
            
            Console.WriteLine(person);
            Student student = new Student("Nick Pappas");
            Student student2 = new Student("Nick Alexiou");
            Student student3 = new Student("Peter Pappas");
            Student student4 = new Student("George Pappas");
            Student student5 = new Student("Panos Giannou");
            Student student6 = new Student("Lefteris Pappas");
            Teacher teacher = new Teacher("Tasos Lelakis");
            Console.WriteLine(student);
            Console.WriteLine("---------------Inheritance Grouping------------------");

            List<Person> people = new List<Person>();

            people.Add(person);
            people.Add(student);
            people.Add(student2);
            people.Add(student3);
            people.Add(student4);
            people.Add(student5);
            people.Add(student6);
            people.Add(teacher);

            foreach(Person p in people)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("-----------------Interface Grouping------------------------");

            Product product1 = new Product();
            Product product2 = new Product();

            product1.Name = "Product 1";
            product2.Name = "Product 2";

            product1.Code = "123";
            product1.Description = "Auto to ladi einai fovero";
            product2.Code = "123";
            product2.Description = "Auto to ladi einai fovero";


            List<ICrudable> crudables = new List<ICrudable>();

            crudables.Add(person);
            crudables.Add(student);
            crudables.Add(student2);
            crudables.Add(student3);
            crudables.Add(student4);
            crudables.Add(student5);
            crudables.Add(student6);
            crudables.Add(teacher);
            crudables.Add(product1);
            crudables.Add(product2);

            foreach(ICrudable c in crudables)
            {
                Console.WriteLine(c);
            }


            Console.WriteLine("--------Summarize of object product---------");
            
        }
    }
}
