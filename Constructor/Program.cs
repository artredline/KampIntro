using System;

namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Constructor Working!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
