using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //by default connect to Server : (localdb)\mssqllocaldb
            using (var ctx = new SchoolContext())
            {
                Student stud = new Student { StudentName = "New Student 02" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
                foreach (var student in ctx.Students)
                {
                    Console.WriteLine(student.StudentName);
                }
                
            }

            Console.ReadKey();
        }
    }
}
