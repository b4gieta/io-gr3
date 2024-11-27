public class Entry
{
	public string polishWord;
	public string englishWord;

	public Entry(string polishWord, string englishWord)
    {
		this.polishWord = polishWord;
		this.englishWord = englishWord;
    }
}

public class Dictionary
{
	public List<Entry> entries = new List<Entry>();

	public Dictionary(string sourcePath)
    {
        foreach (string line in File.ReadLines(sourcePath))
        {
            string[] words = line.Split(' ');
            Entry e = new Entry(words[0], words[1]);
            entries.Add(e);
        }
    }

    public void ShowDictionary()
    {
        foreach (Entry e in entries)
        {
            Console.WriteLine(e.polishWord + ' ' + e.englishWord);
        }
    }
}
