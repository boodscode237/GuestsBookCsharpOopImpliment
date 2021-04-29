using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessBookLibrary.Models;

// Capture the information about each guess(assuming that there is at least one guest and unknown maximum)
// Info to capture = firstName, lastName, massage to the host
// once captured, loop through each guest and print their info

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GuestModel> guests = new List<GuestModel>();
            string moreGuestsComing = "";

            do
            {
                GuestModel guest = new GuestModel();

                Console.Write("What is your first name: ");
                guest.FirstName = Console.ReadLine();

                Console.Write("What is your last name: ");
                guest.LastName = Console.ReadLine();

                Console.Write("What message do you want to send to your host: ");
                guest.MessageToHost = Console.ReadLine();

                Console.Write("Are more guests coming (yes/no): ");
                moreGuestsComing = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();
            } while (moreGuestsComing != null && moreGuestsComing.ToLower() == "yes");

            foreach (GuestModel guest in guests)
            {
                Console.WriteLine(guest.GuestInfo);
            }


            Console.ReadLine();
        }
    }
}
