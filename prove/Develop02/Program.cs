using System;
// My exceeding requirement is that I added a brainstorm timer before you start writing. I got help from Alexei Levenkov on Stack Overflow: https://stackoverflow.com/questions/18004902/countdown-timer-in-console-application
class Program
{
    static void Main(string[] args) {
        Journal journal = new Journal();
        bool menu = true;

        do
        {
            Console.WriteLine("Please enter a number to select one of the following choices.\n1. Write(1)\n2. Display(2)\n3. Load(3)\n4. Save(4)\n5. Quit(5)\n What would you like to do?: ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                // My exceeding requirement is that I added a brainstorm timer before you start writing. I got help from Alexei Levenkov on Stack Overflow: https://stackoverflow.com/questions/18004902/countdown-timer-in-console-application
                var origRow = Console.CursorTop;
            for (int a = 60; a >= 0; a--) {
                Console.SetCursorPosition(0, origRow);
                Console.Write("Please brainstorm until the timer finishes. {0}", a);
                System.Threading.Thread.Sleep(1000);
                }
                Console.SetCursorPosition(0, origRow);
                Console.Write("Finished! type 'ready' to begin.");
                string ready = Console.ReadLine();
                PromptGenerator prompts = new PromptGenerator();
                string prompt = prompts.WritePrompt();
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();

                DateTime CurrentTime = DateTime.Now;
                string date = CurrentTime.ToShortDateString();
                journal._date = date;
                journal._prompt = prompt;
                journal._entry = entry;
                journal.AddEntry();
            } else if (userInput == "2")
            {
                journal.Display();

            } else if (userInput == "3")
            {
                SaveLoad loading = new SaveLoad();
                loading._journal = journal;
                Console.WriteLine("What is the name of the file you would like to load? Somthing like entry.txt:  ");
                string loadFile = Console.ReadLine();
                loading._loadFile = loadFile;
                loading.Load();

            } else if (userInput == "4")
            {
                SaveLoad saving = new SaveLoad();
                saving._journal = journal;
                Console.WriteLine("What do you want to name the file. Use this format: Entry.txt: ");
                string saveFile = Console.ReadLine();
                saving._saveFile = saveFile;
                saving.Save();

            } else if (userInput == "5")
            {
                menu = false;

            } else
            {
                Console.WriteLine("Somthing went wrong, please try again.");
            }

        } while (menu);
    }
}