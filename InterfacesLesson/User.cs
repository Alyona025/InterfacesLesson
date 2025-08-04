using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    class User : Creature
    {

        public string Name;
        public User(string Name)
        {
            this.Name = Name;
            base.sound = $"Привет! Меня зовут {Name}";

        }

    }
}
