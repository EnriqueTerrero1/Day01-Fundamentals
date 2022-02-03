using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class CRUD
    {
        List<Person> persons = new List<Person>();


        public void AddPerson(Person person)

        {
            persons.Add(person);

        }
        public List<Person> GetallPersons()
        {
            return (persons);
        }

        public void RemovePerson(int index) {   
            
            persons.RemoveAt(index-1); 
        }
        public void UpdatePerson(Person person,int index) {

            persons[index - 1] = person; 

           /* persons[i-1].Name = Name;
            persons[i-1].Lastname = LastName;
            persons[i-1].ages = ages;*/
        
        }

        

    }
}
