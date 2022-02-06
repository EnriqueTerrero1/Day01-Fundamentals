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
            int OptionContinueQuestion;
            
            do
            {
                Menu();
            } while (continueQuestion.Question());
        }
        ContinueQuestion continueQuestion = new ContinueQuestion();
        
       public int DeleteNumber, UpdateNumber;


        Animal animal;
        dataAnimal DataAnimal = new dataAnimal();
       

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

      
        void addAnimal()
        {
            var dataanimal= DataAnimal.CaptureAnimalData();
           Add(dataanimal);
            Console.WriteLine("Animal Agregado");

        }
        void removeAnimal() {
            Console.WriteLine("Indique el animal a eliminar");
            DeleteNumber = int.Parse( Console.ReadLine());
            Remove(DeleteNumber);
            Console.WriteLine("Animal eliminado");
                }
        void updateAnimal()
        {
            Console.WriteLine("Indique el numero del animal a actualizar");
            UpdateNumber = int.Parse(Console.ReadLine());
            var dataAnimal = DataAnimal.CaptureAnimalData();
            Update(dataAnimal, UpdateNumber);
        }
        void ShowAnimal()
        {
            int index = 1;
            Getall().ForEach(animal => Console.WriteLine($" {index++}  Familia del animal: {animal.AnimalFamily} Peso: {animal.Weight} Nombre: {animal.Name} Tipo de animal: {animal.AnimalType}"));

        }


    }
}
