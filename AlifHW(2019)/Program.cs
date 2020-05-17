using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Text;
namespace AlifHW_2019_
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAllNames(new List<object>() { new Person { Id = 1, Name = "George Washington" }, new Cities { ID = 1, Name = "Dushanbe" } });
            Cook cook1 = new Cook { Age = 21, Name = "Payrav" };
            ChefWithRat chef = new ChefWithRat { Age = 40, Name = "Khurshed" };
            cook1.CookPotato();
            chef.CookRatatouile();
            Programmer Shahzod = new Programmer();
            Programmer Khurshed = new Programmer();
            Programmer Firdavs = new Programmer();
            TeamLead AkiAziz = new TeamLead();
            AkiAziz.CreateTasks();
            AkiAziz.GiveTask(Shahzod,"Auction");
            Shahzod.WorkonTask();
        }
        static void GetAllNames(List<object> obj)
        {
            foreach (var item in obj)
            {
                if (item is Person)
                {
                    Person p = item as Person;
                    Console.WriteLine("Person:" + p.Name);
                }
                if (item is Cities)
                {
                    Cities c = item as Cities;
                    Console.WriteLine("City:" + c.Name);
                }
            }
        }
    }
    interface Iprogrammer
    {
        public void WorkonTask();
    }
    interface IManager
    {
        public void GiveTask(Programmer p, string Task);
        public void CreateTasks();
    }
    public class Programmer : Iprogrammer
    {
        public string Task { get; set; }
        public void WorkonTask()
        {
            Console.WriteLine("Working on "+Task);
        }
    }
    public class TeamLead:Iprogrammer,IManager
    {
        public void WorkonTask()
        {
            Console.WriteLine("Working on Task");
        }
        public void GiveTask( Programmer p,string Task)
        {
            Console.WriteLine("Giving Task");
            p.Task = Task;
        }
        public void CreateTasks()
        {
            Console.WriteLine("Creating Tasks");
        }
    }
    class Cook
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void CookPotato()
        {
            Console.WriteLine("I cooked Potato");
        }
    }
    class ChefWithRat : Cook
    {
        public void CookRatatouile()
        {
            Console.WriteLine("I cooked ratatouile");
        }
    }
}