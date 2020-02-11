using System;
using System.Collections.Generic;

namespace Asserttask
{
    public class ListOfNumber
    {
        List<int> myList = new List<int>() { 2, 3, 7 };
        public List<int> Numberlist(List<int> ls)
        {
            List<int> List = new List<int>();
            List<int> list1 = new List<int>() { 10, 20, 30 };
            //List.ForEach(l => Console.WriteLine(l));
            foreach (var l in ls)
            {
                List.Add(l);
            }
            return List;

        }

        public void checklistwhetherlistisnull(List<int> mylist)
        {
            try
            {
                if (myList != null)
                {
                    Console.WriteLine("list is not null");
                }
                else
                {
                    Console.WriteLine("list is null");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Execption caught" + e);
            }
        }


        public void Get_Code()
        {
            var expected = new List<int>();
            expected.AddRange(new[] { 100, 400, 200, 900, 2300, 1900 });

            var actual = new List<int>();
            actual.AddRange(new[] { 100, 400, 200, 900, 2300, 1900 });
        }
        public static void Main(string[] args)
        {

            Console.ReadKey();
            
          }
    }
}
