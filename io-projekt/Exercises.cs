public static class Exercise
{
    public static bool Translate(Entry entry)
    {
        Console.WriteLine("Podaj tlumaczenie: " + entry.polishWord);
        var translation = Convert.ToString(Console.ReadLine());

        if (translation != null && translation == entry.englishWord)
            return true;
        else 
            return false;
    }
}
