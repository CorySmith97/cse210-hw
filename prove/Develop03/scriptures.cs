public class CSScriptures{
    private string _scriptureTitle;
    private string _scripture;
    private List<CSScriptures> _csScriptureStorage = new List<CSScriptures>();

    public CSScriptures(){

    }
    public CSScriptures(string scriptureTitle, string scripture){
        _scriptureTitle = scriptureTitle;
        _scripture = scripture;
    }
    public void csPrintTitle()
    {
        Console.WriteLine(_scriptureTitle);
    }


}