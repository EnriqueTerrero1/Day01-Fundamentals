// See https://aka.ms/new-console-template for more information
using Day01;
string Name, Lastname;
int ages , DeleteNumber,UpdateNumber;
int OptionContinueQuestion;
Console.WriteLine("Estas en el mantenimiento de Persona");
//AnimalService animal;
//animal =new AnimalService();

  
//CRUD<Person> crud = new CRUD<Person>();

//CRUD<Animal> animal = new CRUD<Animal>();
//AnimalService animalService = new AnimalService();
PersonService personService = new PersonService();
//Person person;
//Boolean ContinueOption = false;


/*do
{
    Menu();
    Console.WriteLine("Desea continuar? (1 = Si / 2 = No)");
    OptionContinueQuestion = int.Parse(Console.ReadLine());
    if (OptionContinueQuestion == 1)
    {
        ContinueOption = true;
    }else
    {
        ContinueOption = false;
    }


} while (ContinueOption = true);






void Menu()
{
    
    int MenuOption;
    Console.WriteLine("1.Agregar usuario");
    Console.WriteLine("2.Eliminar usuario");
    Console.WriteLine("3.Consultar usuario");
    Console.WriteLine("4.Actualizar usuario");
    MenuOption=int.Parse(Console.ReadLine());

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
    person =new Person();
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
    var dataperson=DataPerson();
    personService.AddPerson(dataperson);
    Console.WriteLine("persona agregada");
    
    
}




/*void ContinueQuestion()
{

    Console.WriteLine("Desea continuar? (1 = Si / 2 = No)");
     OptionContinueQuestion = int.Parse(Console.ReadLine());
    if (OptionContinueQuestion == 1)
    {
        DataPerson();
    }
    else
    {
        Showpersons();
    }

}*/

/*void Showpersons (){
    int index = 1;
    personService.GetallPersons().ForEach(person => Console.WriteLine($" {index++}  Nombre: {person.Name} Apellido: {person.Lastname} Edad: {person.ages}"));
   
}

void RemovePersons() {

    
    Console.WriteLine("Indique el numero del usuario a eliminar");
    DeleteNumber = int.Parse(Console.ReadLine());
    personService.RemovePerson(DeleteNumber);
   
}

void UpdatePersons()
{

    
    Console.WriteLine("Indique el numero del usuario a actualizar");
    UpdateNumber = int.Parse(Console.ReadLine());

    var dataperson = DataPerson();


    personService.UpdatePerson(dataperson,UpdateNumber);
    

}
//Menu(); poner menu al final para no tener que llamarlo en cada funcion*/

