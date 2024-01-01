using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.SubRooms
{
    public class Livingroom : ISubRoom
    {
        public int SubRoomId { get; set; }
        public string SubRoomType { get; set; }

        public Livingroom(int subRoomId, string subRoomType)
        {
            SubRoomId = subRoomId;
            SubRoomType = subRoomType;
        }
    }
}
