using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>()
            {
               new Emp(){Id=1,Fname="jay",Lname="kumar",salary=98500.33,DOJ=new DateTime(day:07,month:10,year:2024)},
             new Emp(){Id=2,Fname="yash",Lname="namburi",salary=99666.33,DOJ=new DateTime(day:26,month:2,year:2025)},
          new Emp(){Id=3,Fname="harinivas",Lname="yelleti",salary=88500.33,DOJ=new DateTime(day:11,month:10,year:2023)},
      new Emp(){Id=4,Fname="ganesh",Lname="mittapalli",salary=98500.33,DOJ=new DateTime(day:12,month:12,year:2020)},

            };


            Console.WriteLine("no of employees:\t"+emps.Count);

            Console.WriteLine("ID\tFirstName\tLast Name\t Salary\tDate of joining");

            foreach(Emp e in emps)
            {
                Console.Write(e.Id+"\t");
                Console.Write(e.Fname+"\t\t");
                Console.Write(e.Lname+"\t\t");
                Console.Write(e.salary+"\t\t");
                Console.Write(e.DOJ+"\t\t");

                Console.WriteLine();
            }



            Emp obj = new Emp();
            Console.WriteLine("enter Id");
            obj.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("enter first name");
            obj.Fname = Console.ReadLine();

            Console.WriteLine("enter last name");
            obj.Lname = Console.ReadLine();

            Console.WriteLine("enter salary");
            obj.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("enter date of joining");
            obj.DOJ = DateTime.Parse(Console.ReadLine());
            emps.Add(obj);


            Console.WriteLine("no of employees:\t" + emps.Count);

            Console.WriteLine("ID\t FirstName \t Last Name \t Salary \t Date of joining");

            foreach (Emp e in emps)
            {
                Console.Write(e.Id + "\t");
                Console.Write(e.Fname + "\t\t");
                Console.Write(e.Lname + "\t\t");
                Console.Write(e.salary + "\t\t");
                Console.Write(e.DOJ.ToShortTimeString() + "\t\t");

                Console.WriteLine();
            }



        }
    }
}
