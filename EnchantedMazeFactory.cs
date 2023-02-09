using System;
using System.Collections.Generic;
using System.Text;

namespace JIa6upuHT
{
    class EnchantedMazeFactory : MazeFactory
{
public override Room MakeRoom(int number)
    {
        return new EnchantedRoom(number, CastSpell());
    }
    public override Door MakeDoor(Room room1, Room room2)
    {
        return new DoorNeedingSpell(room1, room2);
    }
    protected Spell CastSpell()
    {
        return null;
    }
}
}
