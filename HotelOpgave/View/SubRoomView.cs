using HotelOpgave.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.View
{
    public class SubRoomView
    {
        public int SubRoomAmount(int number) 
        {
            Console.Clear();
            Console.Write($"How many Subrooms do you want in Room {number}?");
            int subRoomNuber = Convert.ToInt32(Console.ReadLine());
            return subRoomNuber;
        }
        public void SubRoomBathroom()
        {
            Console.Clear();
            Console.WriteLine("One Room needs to be a Bathroom.");
            Console.ReadKey();
        }
        public void SubRoomType(int n)
        {
            Console.Clear();
            Console.WriteLine($"What type of room should Subroom {n} be:");
            Console.WriteLine("[1]: Bathroom");
            Console.WriteLine("[2]: Bedroom");
            Console.WriteLine("[3]: Kitchen");
            Console.WriteLine("[4]: Livinroom");
        }
    }
}
