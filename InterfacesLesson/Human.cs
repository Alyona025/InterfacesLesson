using System;

namespace InterfacesLesson
{
    class Human : Creature, IHasHair
    {

        public string HairColor { get; set; }

        public string Name;
        public Human(string Name, string HairColor)
        {
            this.Name = Name;
            base.sound = $"Привет! Меня зовут {Name}";
            this.HairColor = HairColor;

        }

        public void RemoveHairColor()
        {
            Console.WriteLine($"Цвет волос человека - {HairColor}");
        }

    }
}
