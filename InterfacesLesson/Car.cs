using System;

namespace InterfacesLesson
{
    class Car: Creature
    {

        public bool included;

        public Car(bool included)
        {
            this.included = included;
            if (included)
            {
                base.sound = "~Биип!";
            }
            else { base.sound = "..."; }
        }
    

    }
}
