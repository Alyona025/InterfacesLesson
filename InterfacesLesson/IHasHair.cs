using System;

namespace InterfacesLesson
{
    internal interface IHasHair
    {
        string HairColor { get; set; }

        void RemoveHairColor();
    }
}
