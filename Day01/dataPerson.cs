using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class dataPerson
    {
        string Name, Lastname;
        int ages;
        Person person;
      public Person CapturePersonData()
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
    }
}
