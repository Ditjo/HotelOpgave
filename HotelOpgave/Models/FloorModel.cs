using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgave.Models
{
    public class FloorModel
    {
        public int FloorNumber { get; set; }

        public List<RoomModel> ListRooms { get; set; }
    }
}
