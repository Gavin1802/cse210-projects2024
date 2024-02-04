public class JournalEntry {
    public string response;
    public string prompt;
    public string date;

    public string Export()
    {
        return $"{response}|{prompt}|{date}";
    }

    public JournalEntry(string response, string prompt, string date) {
        this.response = response;
        this.prompt = prompt;
        this.date = date;
    }

    public JournalEntry(string import) {
        var parts = import.Split("|");
        this.response = parts[0];
        this.prompt = parts[1];
        this.date = parts[2];
    }

    public override string ToString()
    {
        return $"{date}: {prompt} - {response}";
    }
    
}


