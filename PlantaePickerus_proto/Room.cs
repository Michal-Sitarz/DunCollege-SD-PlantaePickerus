using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantaePickerus_proto
{
    
    class Room
    {
        public int roomID { get; set; }
        public string roomName { get; set; }

        public Room()
        {

        }
        
        //SETters
        public void setRoomName(string _roomName)
        {
            this.roomName = _roomName;
        }

        public void setRoomID(int _roomID)
        {
            this.roomID = _roomID;
        }

        //GETters
        public string getRoomName()
        {
            return this.roomName;
        }

        public int getRoomID()
        {
            return this.roomID;
        }
        
    }
}
