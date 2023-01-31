using System;

class Program
{
    static void Main(string[] args) {
        var origRow = Console.CursorTop;
            for (int a = 60; a >= 0; a--) {
    Console.SetCursorPosition(0, origRow);
    Console.Write("Please brainstorm until the timer finishes. {0}", a);
    System.Threading.Thread.Sleep(1000);
    }
    Console.SetCursorPosition(0, origRow);
    Console.Write("Finished!");
   }
}
