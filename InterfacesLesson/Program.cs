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

            List<Cow> cows = new List<Cow>();
            List<Car> cars = new List<Car>();
            List<User> users = new List<User>();

            cows.Add(new Cow());
            cows.Add(new Cow());

            cars.Add(new Car(true));

            users.Add(new User("Таня"));
            users.Add(new User("Гриша"));
            users.Add(new User("Саша"));
            users.Add(new User("Даша"));
            users.Add(new User("Кира"));

            Console.WriteLine("Звуки: ");


            for (int i = 0; i < 1; i++)
            {
                foreach (Cow cow in cows)
                {
                  cow.MakeSound();
                }

                foreach (Car car in cars)
                {
                    car.MakeSound();
                }

                foreach (User user in users)
                {
                    user.MakeSound();
                }

            }
        }
    }
}
