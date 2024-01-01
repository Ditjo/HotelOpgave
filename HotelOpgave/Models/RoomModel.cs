using HotelOpgave.SubRooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.Models
{
    public class RoomModel
    {
        public int RoomNumber { get; set; }
        public List <ISubRoom> ListSubRooms { get; set; }
    }
}
