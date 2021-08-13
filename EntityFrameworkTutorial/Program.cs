using EntityFrameworkTutorial.Models;
using System;
using System.Linq;

namespace EntityFrameworkTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }
        
        public static string GetName()
        {
            return "Bill";
        }
    }
}
