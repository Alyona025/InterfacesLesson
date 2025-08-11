using System;
using System.Collections.Generic;

namespace InterfacesLesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cow cow1 = new Cow("Белый");
            Cow cow2 = new Cow("Чёрный");

            Car car1 = new Car(true);

            Human human1 = new Human("Таня", "Рыжий");
            Human human2 = new Human("Гриша", "Чёрный");
            Human human3 = new Human("Саша", "Русый");
            Human human4 = new Human("Даша", "Зелёный");
            Human human5 = new Human("Кира", "Красный");

            Doll doll1 = new Doll("Фиолетовый");
            Doll doll2 = new Doll("Розовый");

            List<Creature> creatures = new List<Creature> { cow1, cow2, car1, human1, human2, human3, human4, human5 };
            List<IHasHair> hasHairs = new List<IHasHair> { cow1, cow2, human1, human2, human3, human4, human5, doll1, doll2 };

            foreach (Creature creature in creatures)
            {
                creature.MakeSound();

            }
            Console.WriteLine();
            foreach (IHasHair hasHair in hasHairs)
            {
                hasHair.RemoveHairColor();

            }
        }

    }
}
