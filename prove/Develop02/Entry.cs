public class JournalEntry {
    public string response;
    public string prompt;
    public string date;

    public string Export()
    {
        return $"{response}|{prompt}|{date}";
    }

    public override string ToString()
    {
        return $"{date}: {prompt} - {response}";
    }
    
}


