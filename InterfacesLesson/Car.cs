using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class Car
    {

        public bool included;
        public string sound;

        public Car(bool included)
        {
            this.included = included;
        }

        public void MakeSound()
        {
            if (included)
            {
                sound = "~Биип!";
            }
            else { sound = "..."; }

            Console.WriteLine($"Звук машины: {sound}");
        }

    }
}
