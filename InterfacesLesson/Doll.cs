using System;

namespace InterfacesLesson
{
    class Doll : IHasHair
    {
        public string HairColor { get; set; }

        public Doll(string HairColor)
        {
            this.HairColor = HairColor;
        }
        public void RemoveHairColor()
        {
            Console.WriteLine($"Цвет волос куклы - {HairColor}");
        }
    }
}
