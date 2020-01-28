using System;
using System.Collections.Generic;
using System.Linq;
using TesteRandom.Entidade;

namespace TesteRandom
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Student> mylist = new List<Student>();

            mylist.Add(new Student("JAMES"));
            mylist.Add(new Student("DAVID"));
            mylist.Add(new Student("PAUL"));
            mylist.Add(new Student("GEORGE"));
            mylist.Add(new Student("LARRY"));

            //shuffle
            var rnd = new Random();
            var result = mylist.OrderBy(item => rnd.Next());

            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
