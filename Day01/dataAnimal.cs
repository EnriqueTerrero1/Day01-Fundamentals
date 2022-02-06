using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class dataAnimal
    {
        Animal animal;
        string Name, AnimalType, AnimalFamily;
        float Weight;
        public Animal CaptureAnimalData()
        {
            animal = new Animal();


            Console.WriteLine("Escriba el nombre del animal?");
            Name = Console.ReadLine();
            animal.Name = Name;
            Console.WriteLine("Escriba el tipo de animal?");
            AnimalType = Console.ReadLine();
            animal.AnimalType = AnimalType;
            Console.WriteLine("Escriba el peso del animal");
            Weight = float.Parse(Console.ReadLine());
            animal.Weight = Weight;
            Console.WriteLine("Escriba la familia del animal");
            AnimalFamily = Console.ReadLine();
            animal.AnimalFamily = AnimalFamily;

            return animal;
        }

    }
}
