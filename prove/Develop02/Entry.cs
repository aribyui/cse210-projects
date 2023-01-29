public class Entry
{
    // public List<string> _promptList = new List<string>();
    public string _date;
    public string _prompt;
    public string _entry;

    public Entry()
    {

    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entry}");    
    }

}