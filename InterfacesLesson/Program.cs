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

            // Создаем список Creature
            List<Creature> creatures = new List<Creature>();

            //List<Creature>[] creatures = { cows, cars, users }; // почему-то ошибка

            // Добавляем объекты подклассов
            creatures.AddRange(cows);
            creatures.AddRange(cars);
            creatures.AddRange(users);

            foreach (Creature creature in creatures)
            {
             creature.MakeSound();

            }
        }
       
    }
}
