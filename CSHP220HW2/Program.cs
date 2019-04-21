//Christopher Houston
// C# 220 HW2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHP220HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<Models.User>();

            users.Add(new Models.User { Name = "Dave", Password = "hello" });
            users.Add(new Models.User { Name = "Steve", Password = "steve" });
            users.Add(new Models.User { Name = "Lisa", Password = "hello" });

            //1.Display to the console, all the passwords that are "hello".Hint: Where
            var findHelloPassword = users.Where(p => p.Password == "hello");

            foreach (Models.User u in findHelloPassword)
            {
                Console.WriteLine(u.Password);
            }

            //2. Delete any passwords that are the lower-cased version of their Name. Do not just look 
            //for "steve". It has to be data-driven. Hint: Remove or RemoveAll

            var deleteLowerCase = users.RemoveAll(p => p.Password == p.Name.ToLower());

            //this removes the entire user and not just the password. I'm not sure how to get it
            //to just remove the password using system.linq. 

            //3.Delete the first User that has the password "hello".Hint: First or FirstOrDefault

            var firstHello = users.First(p => p.Password == "hello");
            users.Remove(firstHello);

            //4. Display to the console the remaining users with their Name and Password.

            foreach (Models.User u in users)
            {
                Console.WriteLine("Name: " + u.Name + " Password: " + u.Password);
            }

        }
    }
}
