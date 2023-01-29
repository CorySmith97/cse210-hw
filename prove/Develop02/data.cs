using System.IO;
public class CSData {

    public string _fileName;
    public List<CSEntries> _cscompleteEntry = new List<CSEntries>();

    public void CSDisplayData(){
        foreach (CSEntries entry in _cscompleteEntry){
            entry.CSDisplayEntries();
        }
    }
    public void add(CSEntries entry){
        _cscompleteEntry.Add(entry);
    }
    public void CSWriteDataToFile(){
        using (StreamWriter outputFile = new StreamWriter(_fileName))
                {
                    foreach (CSEntries entry in _cscompleteEntry){
                        outputFile.WriteLine($"{entry._dataTime} ; {entry._promptText} ; {entry._userEntry}");
                    }
                    
                }
    }
    public void CSReadFile()
    {
        string[] lines = File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            CSEntries entry = new CSEntries();
            entry._dataTime = parts[0];
            entry._promptText = parts[1];
            entry._userEntry = parts[2];


            add(entry);
        }
    }
    
}