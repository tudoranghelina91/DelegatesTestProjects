using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    class Program
    {
        public delegate int GetAge(Student s);
        public delegate string GetDetails (string name, int age);
        public delegate string PrintDel();

        static void PrintAge(Student s, GetAge p)
        {
            Console.WriteLine(p(s));
        }

        static void GetDetailsFunction(Student s, GetDetails getDetails)
        {
            Console.WriteLine(getDetails(s.Name, s.Age));
        }

        static void Print(PrintDel printDel)
        {
            Console.WriteLine(printDel());
        }

        static void Main(string[] args)
        {
            Student student = new Student("S1", 20);
            
            // anonymous method
            PrintAge(student, delegate
            {
                return student.Age;
            });

            // 1. Remove the delegate keyword and insert lambda symbol between the definition and signature
            PrintAge(student, /*delegate*/ (s) => { return s.Age; });

            // 2. Remove curly braces and return keyword
            PrintAge(student, (s) => s.Age);

            // 3. Remove parantheses if only one parameter is needed
            PrintAge(student, s => s.Age);

            // Lambda expression multiple params and statements (with param types)
            GetDetailsFunction(student, (string name, int age) =>
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Name: {name}\nAge:{age}");
                return sb.ToString();
            });

            // Lambda expression multiple params and statements (without param types)
            GetDetailsFunction(student, (/*string */name, /*int */age) => 
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"Name: {name}\nAge:{age}");
                return sb.ToString();
            });

            // Lambda expression without params
            Print(() => "Hello lulu");
            
        }
    }
}
