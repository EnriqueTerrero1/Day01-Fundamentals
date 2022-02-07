// See https://aka.ms/new-console-template for more information
using Day01;


MainMenu();
void MainMenu()
{




    int MenuOption;

    Console.WriteLine("Seleccion la interfaz");
    Console.WriteLine("1.Interfaz de animal");
    Console.WriteLine("2.Interfaz de usuario");
  
    MenuOption = int.Parse(Console.ReadLine());

    switch (MenuOption)
    {
        case 1:
            AnimalService animalService = new AnimalService();

            break;
        case 2:
            PersonService personService = new PersonService();
            break;

        default:
            break;

    }
}


   








