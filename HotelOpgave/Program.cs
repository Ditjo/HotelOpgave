using HotelOpgave.Models;
using System.ComponentModel.Design;
using HotelOpgave.View;
using HotelOpgave.SubRooms;

namespace Program
{
    public class Program
    {
        enum SubRoomTypes
        {
            Bathroom,
            Bedroom,
            Kitchen,
            Livingroom
        }
        static void Main(string[] args)
        {
            Start_Views start_Views = new();
            UserInputModel userInputStart = start_Views.View();
            SubRoomView subRoomView = new();

            HotelModel hotelModel = new HotelModel();
            hotelModel.listFloors = new();
            //Floors
            for (int i = 0; i < userInputStart.Floors; i++)
            {
                FloorModel floor = new();
                floor.FloorNumber = i + 1;
                floor.ListRooms = new();
                //Rooms
                for (int e = 0; e < userInputStart.Rooms; e++)
                {
                    RoomModel room = new();
                    room.RoomNumber = Convert.ToInt32(floor.FloorNumber.ToString() + (e + 1));

                    room.ListSubRooms = new();

                    //SubRooms
                    int subRoomAmount = subRoomView.SubRoomAmount(room.RoomNumber);
                    subRoomView.SubRoomBathroom();
                    Bathroom bathroomMustHave = new(1, SubRoomTypes.Bathroom.ToString(), false);

                    room.ListSubRooms.Add(bathroomMustHave);
                    for (int j = 1; j < subRoomAmount; j++)
                    {
                        subRoomView.SubRoomType(j + 1);

                        ISubRoom subRoom;
                        bool exit = true;
                        do
                        {
                            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                            if (consoleKeyInfo.Key == ConsoleKey.D1)
                            {
                                Bathroom bathroom = new(j + 1, SubRoomTypes.Bathroom.ToString(), false);
                                subRoom = bathroom;
                                exit = false;
                            }
                            else if (consoleKeyInfo.Key == ConsoleKey.D2)
                            {
                                Bedroom bedroom = new(j + 1, SubRoomTypes.Bedroom.ToString());
                                subRoom = bedroom;
                                exit = false;
                            }
                            else if (consoleKeyInfo.Key == ConsoleKey.D3)
                            {
                                Kitchen kitchen = new(j + 1, SubRoomTypes.Kitchen.ToString());
                                subRoom = kitchen;
                                exit = false;
                            }
                            else if (consoleKeyInfo.Key == ConsoleKey.D4)
                            {
                                Livingroom livingroom = new(j + 1, SubRoomTypes.Livingroom.ToString());
                                subRoom = livingroom;
                                exit = false;
                            }
                            else
                            {
                                Bathroom bathroom = new(1,"",false);
                                subRoom = bathroom;
                                exit = true;
                            }
                        } while (exit);

                        //Add Subroom to Room
                        room.ListSubRooms.Add(subRoom);
                    }
                    //Add Room to Floor
                    floor.ListRooms.Add(room);
                }
                //Add Floors to FloorList(Hotel)
                hotelModel.listFloors.Add(floor);
            }

            //----------------------------------
            BreakToilet breakToiletView = new BreakToilet();
            List<IToilet> allBathrooms = new();
            int breakToiletInListPlace;

            HotelOverview.HotelPrint(hotelModel);

            breakToiletView.BreakToiletView();
            ConsoleKeyInfo toiletKeyInfo = Console.ReadKey(true);

            do
            {
                toiletKeyInfo = Console.ReadKey(true);
                if (toiletKeyInfo.Key is ConsoleKey.Y)
                {
                    foreach (var floors in hotelModel.listFloors)
                    {
                        foreach (var rooms in floors.ListRooms)
                        {
                            foreach (var subRooms in rooms.ListSubRooms)
                            {
                                if (subRooms.SubRoomType == SubRoomTypes.Bathroom.ToString())
                                {
                                    allBathrooms.Add((Bathroom)subRooms);
                                }
                            }
                        }
                    }

                    breakToiletView.PickToiletTobreak(hotelModel);
                    breakToiletInListPlace = Convert.ToInt32(Console.ReadLine());

                    IToilet toilet = allBathrooms.ElementAt(breakToiletInListPlace - 1);
                    toilet.IsBroken = true;
                }
            } while (toiletKeyInfo.Key is not ConsoleKey.Y && toiletKeyInfo.Key is not ConsoleKey.N);

            foreach (var toilets in allBathrooms)
            {
                Console.WriteLine(toilets.IsBroken);
            }
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Closing Program");
            Console.ReadKey();

        }
    }
}


