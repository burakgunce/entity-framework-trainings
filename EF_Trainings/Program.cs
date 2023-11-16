using EF_Trainings.Contexts;
using EF_Trainings.Models;

namespace EF_Trainings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext northwindContext = new NorthwindContext();
            List<Customer> Musteriler = northwindContext.Customers.ToList();
        }
    }
}