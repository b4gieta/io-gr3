using System;
Console.WriteLine("Witaj użytkowniku");
//WCZYTANIE FISZEK I SŁOWNIKA//
bool t = true;
while (t)
{
    Console.WriteLine("Wybierz opcję");
    //PO DODANIU FUNKCJI DODAĆ ODWOŁANIA DO NICH//
    Console.WriteLine("1 - - - Opcja 1");
Console.WriteLine("2 - - - Opcja 2");
    Console.WriteLine("3 - - - Opcja 3");
Console.WriteLine("4 - - - Wyjdź");
    string n = Console.ReadLine();
    switch (n)
    {
<<<<<<< Updated upstream
        case "1":

            Console.WriteLine("WYWOŁANIE FUNKCJI 1");
=======
        case "1":          
            dictionary.ShowDictionary();
>>>>>>> Stashed changes
            break;
        case "2":

            Console.WriteLine("WYWOŁANIE FUNKCJI 2");
            break;
        case "3":

            Console.WriteLine("WYWOŁANIE FUNKCJI 3");
            break;
        case "4":
            {
                //ZAPISANIE ZMIAN I POSTĘPÓW//
                Console.WriteLine("Do widzenia");
                t = false;
                break;
            }
    }
    
    
    Console.WriteLine("------------------------");
    Console.WriteLine("Naciśnij dowolny przycisk aby kontynuować");
    if (t)
    Console.ReadKey();
    Console.Clear();
}