public class Journal
{
    public List<Entry> _entries = new List<Entry>();
   public Entry _oneEntry;
    public Journal()
    {

    }

    public void AddEntry()
    {     
        _entries.Add(_oneEntry);
    }

    public void DisplayRandomPrompt()
    {   
        foreach (Entry p in _entries)
        {
            p.Display();
        }
    }


}