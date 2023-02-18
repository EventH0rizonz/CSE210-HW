class Display {
    private string _scripture;
    private string _reference;
    private string _displayMessage;
    public void GetScriptureReference(string scripture, string reference)
    { 
        _scripture = scripture;
        _reference = reference;
    }
    public void DisplayScripture()
    {
        _displayMessage = $"{_reference} - {_scripture}";
        Console.WriteLine(_displayMessage);
    }
}