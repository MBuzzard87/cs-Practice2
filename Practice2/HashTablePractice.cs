using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{

    // Key - Value
    


    class HashTablePractice
    {
        
        
        static void Main(string[] args)
        {
            Hashtable studentsTable = new Hashtable();

            Student stud1 = new Student(1, "Mike", 90);
            Student stud2 = new Student(2, "Buzz", 80);
            Student stud3 = new Student(3, "Joe", 75);
            Student stud4 = new Student(4, "Michael", 95);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);


            Student storedStudent1 = (Student)studentsTable[stud1.Id];


            foreach(DictionaryEntry entry in studentsTable)
            {
                Student temp = (Student)entry.Value;
                Console.WriteLine("Student ID: {0} \nName: {1} \nGPA: {2}\n\n", temp.Id, temp.Name, temp.GPA);
            }

            foreach (Student value in studentsTable.Values)
            {
                
                Console.WriteLine("Student ID: {0} \nName: {1} \nGPA: {2}\n\n", value.Id, value.Name, value.GPA);
            }


            Console.WriteLine("Student ID: {0} \nName: {1} \nGPA: {2}", storedStudent1.Id, storedStudent1.Name, storedStudent1.GPA);

            Console.ReadKey();

        }



    }





    class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }



    }

}
