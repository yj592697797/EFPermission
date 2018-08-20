using EFPermission.DbManager;
using EFPermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPermission
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PermissionContext())
            {
                //var power = new Power
                //{
                //    Name = "View"
                //};

                //db.Powers.Add(power);
                //db.SaveChanges();

                foreach (var item in db.Powers)
                {
                    Console.WriteLine(item.Name);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
