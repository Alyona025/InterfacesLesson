using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow1 = new Cow();
            Car car1 = new Car(false);
            User user1 = new User("Гриша");

            Console.WriteLine("Звуки: ");
            cow1.MakeSound();
            car1.MakeSound();
            user1.MakeSound();
        }
    }
}
