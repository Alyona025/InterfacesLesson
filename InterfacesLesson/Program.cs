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
            Cow cow2 = new Cow();

            Car car1 = new Car(false);

            User user1 = new User("Гриша");
            User user2 = new User("Маша");
            User user3 = new User("Даша");
            User user4 = new User("Ваня");
            User user5 = new User("Саша");

            Console.WriteLine("Звуки: ");


            for (int i = 0; i < 1; i++ )
            {
                cow1.MakeSound();
                cow2.MakeSound();
                car1.MakeSound();
                user1.MakeSound();
                user2.MakeSound();
                user3.MakeSound();
                user4.MakeSound();
                user5.MakeSound();

            }
        }
    }
}
