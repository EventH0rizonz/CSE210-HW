using System;

class Program
{
    static void Main(string[] args) {
        scripture scripCall = new scripture();
        //My Exceding requirements is haveing multiple scriptures to pull from in a list to give the memorizer more challenge. Located in Scripture.cs
        string scripture = scripCall.GiveScripture();
        string reference = scripCall.GiveReference();
        Word wordCheck = new Word();
        Display displayCheck = new Display();
        bool quit = false;
        do {
            wordCheck.SetScripture(scripture);
            displayCheck.GetScriptureReference(scripture, reference);
            displayCheck.DisplayScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to continue");
            string input = Console.ReadLine().ToLower();
            bool allHidden = wordCheck.AllWordsHidden();
            if (input == "quit") {
                quit = true;
            };
            scripture = wordCheck.HideWord();
        } while (!quit);
    }
}