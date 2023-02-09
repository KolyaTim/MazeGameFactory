namespace JIa6upuHT
{
    internal class EnchantedRoom : Room
    {
        private Spell spell;
        public EnchantedRoom(int roomNo) : base(roomNo)
        {

        }
        public EnchantedRoom(int roomNo, Spell spell) : base(roomNo)
        {
            this.spell = spell;
        }
    }
}