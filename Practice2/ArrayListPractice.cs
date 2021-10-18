using System;
using System.Collections;


namespace Practice2
{
    class ArrayListPractice
    {
       


        static void Main(string[] args)
        {
            // declaring an ArrayList
            ArrayList myArrayList = new ArrayList();

            // delcaring an ArrayList witha defined amount of objects
            ArrayList myArrayList2 = new ArrayList(100);

            myArrayList.Add(34);
            myArrayList.Add("Mike");
            myArrayList.Add(2.50);
            myArrayList.Add(35);
            myArrayList.Add("Munir");
            myArrayList.Add(true);



            // delete element with specific value from ArrayList
            myArrayList.Remove("Mike");

            // delete element at specific index
            myArrayList.RemoveAt(1);


            Console.WriteLine(myArrayList.Count);


            foreach(object o in myArrayList)
            {
                if(o is int)
                {
                    Console.WriteLine(o);
                }
            }
            myArrayList.Clear();
            Console.WriteLine(myArrayList.Count);

            Console.ReadKey();
        }


    }
}
