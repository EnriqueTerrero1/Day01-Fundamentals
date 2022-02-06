using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    
    internal class PersonService: CRUD<Person>
    {
        int DeleteNumber, UpdateNumber;
      public PersonService()
        {
            do
            {
                Menu();
            }while( continueQuestion.Question());


             
        }



        
        ContinueQuestion continueQuestion = new ContinueQuestion(); 
        dataPerson dataPerson = new dataPerson();

        void Menu()
        {

           


            int MenuOption;
            Console.WriteLine("1.Agregar usuario");
            Console.WriteLine("2.Eliminar usuario");
            Console.WriteLine("3.Consultar usuario");
            Console.WriteLine("4.Actualizar usuario");
            MenuOption = int.Parse(Console.ReadLine());

            switch (MenuOption)
            {
                case 1:
                    AddPerson();

                    break;
                case 2:
                    RemovePersons();
                    break;
                case 3:
                    Showpersons();
                    break;
                case 4:
                    UpdatePersons();
                    break;

                default:
                    break;

            }



        }
      
        void AddPerson()
        {
            
            var dataperson = dataPerson.CapturePersonData();
           
            Add(dataperson);
            Console.WriteLine("persona agregada");
        }
        void Showpersons()
        {
            int index = 1;
            Getall().ForEach(person => Console.WriteLine($" {index++}  Nombre: {person.Name} Apellido: {person.Lastname} Edad: {person.ages}"));

        }

        void RemovePersons()
        {


            Console.WriteLine("Indique el numero del usuario a eliminar");
            DeleteNumber = int.Parse(Console.ReadLine());
            Remove(DeleteNumber);

        }

        void UpdatePersons()
        {
            Console.WriteLine("Indique el numero del usuario a actualizar");
            UpdateNumber = int.Parse(Console.ReadLine());
            var dataperson = dataPerson.CapturePersonData();
            Update(dataperson, UpdateNumber);


        }
    }
}
