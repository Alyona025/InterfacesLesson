using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class Creature
    {
        public string sound;
        public Creature()
        { 
        
        }

        public void MakeSound()
        {
            Console.WriteLine(sound);
        
        }
    }
}
