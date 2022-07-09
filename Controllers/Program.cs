using System;

namespace TestA.Controllers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();
            foreach (var item in db.Histories.OrderBy((h) => h.Date))
            {
                Console.WriteLine(item.Date);
            }
        }
    }
}
