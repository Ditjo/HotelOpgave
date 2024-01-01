using HotelOpgave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HotelOpgave.View
{
    public class Start_Views
    {
        public UserInputModel View() 
        {
            UserInputModel userInput = new();

            Console.WriteLine("Welcome to Hotel Designer IO");
            Console.Write("How many Floors do you want: ");
            userInput.Floors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("How many Rooms do you want per floor: ");
            userInput.Rooms = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"You have ordered a Hotel with {userInput.Floors} floors, and {userInput.Rooms} rooms per floor.");
            Console.ReadKey();
            return userInput;
        }
    }
}
