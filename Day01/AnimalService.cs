using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class AnimalService:CRUD<Animal>
    {
        public AnimalService()
        {
            Menu();
        }
       public string Name;
       public string AnimalType;
       public  float Weight;
       public  string AnimalFamily;
       public int DeleteNumber, UpdateNumber;


        Animal animal;
        AnimalService animalservice = new AnimalService();

        void Menu()
        {

            int MenuOption;
            Console.WriteLine("1.Agregar Animal");
            Console.WriteLine("2.Eliminar Animal");
            Console.WriteLine("3.Consultar Animal");
            Console.WriteLine("4.Actualizar Animal");
            MenuOption = int.Parse(Console.ReadLine());

            switch (MenuOption)
            {
                case 1:
                    addAnimal();

                    break;
                case 2:
                    removeAnimal();
                    break;
                case 3:
                    ShowAnimal();
                    break;
                case 4:
                    updateAnimal();
                    break;

                default:
                    break;

            }



        }

        Animal DataAnimal()
        {
             new Animal();

            
            Console.WriteLine("Escriba el nombre del animal?");
            Name = Console.ReadLine();
            animal.Name=Name;
            Console.WriteLine("Escriba el tipo de animal?");
            AnimalType = Console.ReadLine();
            animal.AnimalType = AnimalType;
            Console.WriteLine("Escriba el peso del animal");
            Weight = float.Parse( Console.ReadLine());
            animal.Weight=Weight;
            Console.WriteLine("Escriba la familia del animal");
            AnimalFamily= Console.ReadLine();
            animal.AnimalFamily=AnimalFamily;

            return animal;
        }
        void addAnimal()
        {
            var dataanimal= DataAnimal();
            animalservice.Add(dataanimal);
            Console.WriteLine("Animal Agregado");

        }
        void removeAnimal() {
            Console.WriteLine("Indique el animal a eliminar");
            DeleteNumber = int.Parse( Console.ReadLine());
            animalservice.Remove(DeleteNumber);
            Console.WriteLine("Animal eliminado");
                }
        void updateAnimal()
        {
            Console.WriteLine("Indique el numero del animal a actualizar");
            UpdateNumber = int.Parse(Console.ReadLine());

            var dataAnimal = DataAnimal();


            animalservice.Update(dataAnimal, UpdateNumber);
        }
        void ShowAnimal()
        {
            int index = 1;
            animalservice.Getall().ForEach(person => Console.WriteLine($" {index++}  Familia del animal: {animal.AnimalFamily} Peso: {animal.Weight} Nombre: {animal.Name} Tipo de animal: {animal.AnimalType}"));

        }


    }
}
