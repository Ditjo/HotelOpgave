using HotelOpgave.Models;
using HotelOpgave.SubRooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.View
{
    public class BreakToilet
    {
        public void BreakToiletView()
        {
            Console.WriteLine("Do you want to break a toilet?");
            Console.WriteLine("[Y]");
            Console.WriteLine("[N]");
        }

        public void PickToiletTobreak(HotelModel Hotel)
        {
            int i = 0;
            Console.Clear();
            Console.WriteLine("Pick a Toilet to break:");

            foreach (var floors in Hotel.listFloors)
            {
                foreach (var rooms in floors.ListRooms)
                {
                    foreach (var subRooms in rooms.ListSubRooms)
                    {
                        if (subRooms.SubRoomType == "Bathroom")
                        {
                            ++i;
                            Console.WriteLine($"[{i}] Toilet in room: {rooms.RoomNumber} with id: {subRooms.SubRoomId}");
                        }
                    }
                }
            }
        }
    }
}
