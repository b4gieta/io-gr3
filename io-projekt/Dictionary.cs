using System;

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
	public List <Entry> entries = new List <Entry>();
}
