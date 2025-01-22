Console.WriteLine("Witaj użytkowniku");
Points points = new Points();
Dictionary dictionary = new Dictionary(@"dictionary.txt");
bool t = true;
while (t)
{
    Console.WriteLine("Wybierz opcję");
    Console.WriteLine("1 - - - Wyświetl słownik");
    Console.WriteLine("2 - - - Wykonaj ćwiczenie");
    Console.WriteLine("3 - - - Zmodyfikuj słownik");
    Console.WriteLine("4 - - - Zresetuj postępy");
    Console.WriteLine("5 - - - Wyjdź");
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
            if (result)
            {
                points.AddPoints();
                Console.WriteLine("Brawo, dodano punkt!");
            }
            else
            {
                points.SubstractPoints();
                Console.WriteLine("Skill issue, odejmujemy punkt!");
            }
                
            break;
        case "3":
            {
                Console.WriteLine("1 - - - Dodaj słowo");
                Console.WriteLine("2 - - - Usuń słowo");
                string m = Console.ReadLine();
                if (m == "1")
                {

                    Console.WriteLine("Podaj słowo polskie");
                    string Word_polish = Console.ReadLine();
                    Console.WriteLine("Podaj słowo angielskie");
                    string Word_english = Console.ReadLine();

                    dictionary.AddToDictionary(Word_polish, Word_english);
                }
                else
                {
                    string Word = Console.ReadLine();
                    dictionary.DeleteFromDictionary(Word);
                }
                break;
            }
        case "4":
            points.ResetPoints();
            Console.WriteLine("Pomyślnie zresetowano postępy!");
            break;
        case "5":
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