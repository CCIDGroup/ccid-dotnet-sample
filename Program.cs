using System;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Hello World")
            
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string getUser(){
            return this.Name;
        }
    }
}
