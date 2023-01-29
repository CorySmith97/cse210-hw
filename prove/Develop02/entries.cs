public class CSEntries {
    public string _dataTime;
    public string _promptText = "";
    public string _userEntry = "";

    public void CSDisplayEntries(){
        Console.WriteLine($"{_dataTime}: Prompt: {_promptText}");
        Console.WriteLine(_userEntry);
        Console.WriteLine();
    }
}