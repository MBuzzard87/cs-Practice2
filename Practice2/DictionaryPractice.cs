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
            string key1 = "CEO";
            string key2 = "Hr";
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

            string keyToUpdate = "CEO";
            if(myEmpDictionary.ContainsKey(keyToUpdate))
            {
                myEmpDictionary[keyToUpdate] = new Employee("Software Developer", "Michael", 35);
                Console.WriteLine("Employee updated!!!");
            } else
            {
                Console.WriteLine("No employee found with key");
            }


            Console.WriteLine("\n");
            for (int i = 0; i < myEmpDictionary.Count; i++)
            {
                KeyValuePair<string, Employee> keyValuePair = myEmpDictionary.ElementAt(i);

                Console.WriteLine("Key: {0} is at position {1}", keyValuePair.Key, i);

                Employee empVal = keyValuePair.Value;
                Console.WriteLine("Employee Name: {0}, Position: {1}, Age: {2}\n", empVal.Name, empVal.Position, empVal.Age);



            }

            Console.WriteLine("There are {0} employees a BuzzCorp",myEmpDictionary.Count);

            if(myEmpDictionary.Remove(keyToUpdate))
            {
                Console.WriteLine("Employee removed");
            } else
            {
                Console.WriteLine("No employee found");
            }

            if(myEmpDictionary.ContainsKey(keyToUpdate))
            {
                Console.WriteLine("Why is this employee still here?");
            } else
            {
                Console.WriteLine("He was fired last week");
            }


            Console.WriteLine("There are {0} employees a BuzzCorp", myEmpDictionary.Count);




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
