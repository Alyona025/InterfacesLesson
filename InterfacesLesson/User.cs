using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class User
    {
        public string Name;
        public User(string Name) 
        {
            this.Name = Name;
        }

        public void MakeSound()
        {
            Console.WriteLine($"Человек сказал: Привет! Меня зовут {Name}");
        }
    }
}
