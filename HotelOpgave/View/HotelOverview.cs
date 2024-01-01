using HotelOpgave.Models;
using HotelOpgave.SubRooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.View
{
    public class HotelOverview
    {
        public static void HotelPrint(HotelModel hotel)
        {
            foreach (var floor in hotel.listFloors)
            {
                Console.WriteLine($"----------Floor Number {floor.FloorNumber}----------");
                foreach (var room in floor.ListRooms)
                {
                    Console.WriteLine($"*-* Room Number {room.RoomNumber}");
                    foreach (var subrooms in room.ListSubRooms)
                    {
                        Console.WriteLine($"ID:{subrooms.SubRoomId} -Type of Room: {subrooms.SubRoomType}");
                        if (subrooms.SubRoomType == "Bathroom")
                        {
                            Bathroom bathroom = (Bathroom)subrooms;
                            Console.WriteLine($" - Is Toilet Broken: {bathroom.IsBroken}");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
