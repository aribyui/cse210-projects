public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    
    public Journal()
    {

    }

    public void AddEntry()
    {     
       
    }

    public void DisplayRandomPrompt()
    {
        foreach (Entry p in _entries)
        {
            p.Display();
        }
    }


}