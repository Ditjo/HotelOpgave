using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.SubRooms
{
    public class Bathroom : ISubRoom, IToilet
    {
        public int SubRoomId { get; set; }
        public string SubRoomType { get; set; }
        public bool IsBroken { get; set; }

        public Bathroom(int subRoomId, string subRoomType, bool isBroken)
        {
            SubRoomId = subRoomId;
            SubRoomType = subRoomType;
            IsBroken = isBroken;
        }
    }
}
