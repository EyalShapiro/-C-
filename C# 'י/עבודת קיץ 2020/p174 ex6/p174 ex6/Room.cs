using System;
using System.Collections.Generic;
using System.Text;

namespace p174_ex6
{
    class Room
    {
        private string type;
        private int length;//אורך החדר 
        private int rorb;//רורב חדר 
        public Room(string type,int length, int rorb)
        {
            this.type = type; 
            this.length = length;
            this.rorb = rorb;
        }
        public Room(Room room)
        {
            type = room.GetRoomType();
            length = room.GetLength();
            rorb = room.GetRorb();
        }
        public string GetRoomType()
        {
            return type;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetRorb()
        {
            return this.rorb;
        }
        public void SetLength(int lengthToSet)
        {
            this.length = lengthToSet;
        }
        public void SetRorb(int rorbToSet)
        {
            this.rorb = rorbToSet;
        }
        public void SetType(string type)
        {
            this.type = type;
        }
        public void Copying_Room(Room r)
        {
            this.length = r.GetLength();
            this.rorb = r.GetRorb();
        }
        public int Area()
        {
            return this.length *this.rorb;
        }
        public override string ToString()
        {
            return  this.type+","+this.length + "," + this.rorb ;
        }
    }
}
