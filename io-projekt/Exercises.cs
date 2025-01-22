public static class Exercise
{
    public static bool Translate(Entry entry)
    {
        Console.WriteLine("Podaj tlumaczenie: " + entry.polishWord);
        var translation = Convert.ToString(Console.ReadLine());

        if (translation != null && translation == entry.englishWord) return true;
        else
        {
            Console.WriteLine("Błąd, spróbuj przetłumaczyć jeszcze raz: " + entry.polishWord);
            Console.WriteLine("Pierwsza litera to: " + entry.englishWord[0]);
            translation = Convert.ToString(Console.ReadLine());

            if (translation != null && translation == entry.englishWord) return true;
            else return false;
        }
    }
}
