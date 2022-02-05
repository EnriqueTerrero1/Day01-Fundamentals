using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    
    internal class PersonService: CRUD<Person>
    {
      public PersonService()
        {
            Boolean ContinueOption = false;
           do {
                Menu();
                Console.WriteLine("Desea continuar? (1 = Si / 2 = No)");
                OptionContinueQuestion = int.Parse(Console.ReadLine());
                if (OptionContinueQuestion == 1)
                {
                    ContinueOption = true;
                }
                else
                {
                    ContinueOption = false;
                }


            } while (ContinueOption = true) ;

        }
        string Name, Lastname;
        int ages, DeleteNumber, UpdateNumber;
        int OptionContinueQuestion;
       
        Person person;
       

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
        Person DataPerson()
        {
            Console.WriteLine("Estas en el mantenimiento de Persona");
            person = new Person();
            Console.WriteLine("Agregar person");
            Console.WriteLine("Name");
            Name = Console.ReadLine();
            person.Name = Name;
            Console.WriteLine("Apellido");
            Lastname = Console.ReadLine();
            person.Lastname = Lastname;
            Console.WriteLine("Edad");
            ages = int.Parse(Console.ReadLine());
            person.ages = ages;

            return person;

        }
        void AddPerson()
        {
            
            var dataperson = DataPerson();
            Console.WriteLine(dataperson.Name);
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

            var dataperson = DataPerson();


            Update(dataperson, UpdateNumber);


        }
    }
}
