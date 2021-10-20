using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class DictionaryPractice
    {


        public DictionaryPractice()
        {
            // key = int, value = string

            Dictionary<int, string> myDictionary = new Dictionary<int, string>()
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" }


            };


            Employee[] employees =
            {
                new Employee("CEO", "Mike", 34),
                new Employee("Manager", "Karen", 46),
                new Employee("HR", "Susan", 40),
                new Employee("Developer", "Buzz", 20),
            };

            Dictionary<string, Employee> myEmpDictionary = new Dictionary<string, Employee>();

            foreach(Employee e in employees)
            {
                myEmpDictionary.Add(e.Position, e);
            }
            Employee result = null;
            string key1 = "CTO";
            string key2 = "HR";
            if(myEmpDictionary.ContainsKey(key1))
            {
                Employee emp = myEmpDictionary[key1];
                Console.WriteLine("Employee Name: {0}, Position: {1}, Age: {2}", emp.Name, emp.Position, emp.Age);
            } else
            {
                Console.WriteLine("The position of {0} does not exist at our company", key1);
            }
            Console.WriteLine("\n");

            if (myEmpDictionary.TryGetValue(key2, out result))
            {
                Console.WriteLine("Value successfully retrieved");
                Console.WriteLine("Employee Name: {0}, Position: {1}, Age: {2}", result.Name, result.Position, result.Age);
            }
            else
            {
                Console.WriteLine("That position does not exist");
            }

            Console.WriteLine("\n");
            for (int i = 0; i < myEmpDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = myEmpDictionary.ElementAt(i);

                Console.WriteLine("Key: {0}", keyValuePair.Key);

                Employee empVal = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}, Position: {1}, Age: {2}\n", empVal.Name, empVal.Position, empVal.Age);



            }






        }



    }


    class Employee
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }


        public Employee(string position, string name, int age)
        {
            Position = position;
            Name = name;
            Age = age;
        }


    }

}
