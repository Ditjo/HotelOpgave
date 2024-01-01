using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.SubRooms
{


    public interface ISubRoom
    {
        public int SubRoomId { get; set; }
        string SubRoomType { get; set; }
    }

    public interface IToilet
    {
        bool IsBroken { get; set; }
    }

}
