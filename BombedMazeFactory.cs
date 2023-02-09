using System;
using System.Collections.Generic;
using System.Text;

namespace JIa6upuHT
{
    class BombedMazeFactory : MazeFactory
    {
        // Метод создает взорванные стены.
        public override Wall MakeWall()
        {
            return new BombedWall();
        }
        // Метод создает комнату с бомбой.
        public override Room MakeRoom(int number)
        {
            return new RoomWithBomb(number);
        }
    }
}
