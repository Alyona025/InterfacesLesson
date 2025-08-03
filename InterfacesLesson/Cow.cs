using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class Cow
    {

        public static string sound;

        public Cow()
        {

        }

        public void MakeSound()
        {
            sound = "~Муу";
            Console.WriteLine($"Звук коровы: {sound}");
        }

    }
}
