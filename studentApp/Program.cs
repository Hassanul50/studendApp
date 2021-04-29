using System;

namespace studentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi . this is practice application for student information for asp.netcore corse");

        }
    }
    class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
