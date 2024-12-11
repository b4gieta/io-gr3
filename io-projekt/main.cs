Console.WriteLine("Witaj użytkowniku");
//WCZYTANIE FISZEK I SŁOWNIKA//
Dictionary dictionary = new Dictionary(@"dictionary.txt");
bool t = true;
while (t)
{
    Console.WriteLine("Wybierz opcję");
    //PO DODANIU FUNKCJI DODAĆ ODWOŁANIA DO NICH//
    Console.WriteLine("1 - - - Wyświetl słownik");
    Console.WriteLine("2 - - - Wykonaj ćwiczenie");
    Console.WriteLine("3 - - - Opcja 3");
    Console.WriteLine("4 - - - Wyjdź");
    string n = Console.ReadLine();
    switch (n)
    {
        case "1":
            dictionary.ShowDictionary();
            break;
        case "2":
            Random rnd = new Random();
            int i = rnd.Next(0, dictionary.entries.Count());
            Entry e = dictionary.entries[i];
            bool result = Exercise.Translate(e);
            if (result) Console.WriteLine("Brawo!");
            else Console.WriteLine("Skill issue");
            break;
        case "3":
            Console.WriteLine("WYWOŁANIE FUNKCJI 3");
            break;
        case "4":
            Console.WriteLine("Do widzenia");
            t = false;
            break;
    }
    
    
    Console.WriteLine("------------------------");
    Console.WriteLine("Naciśnij dowolny przycisk aby kontynuować");
    if (t)
    Console.ReadKey();
    Console.Clear();
}