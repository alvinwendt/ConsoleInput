namespace ConsoleInput;

internal class Program
{
    static void Main(string[] args)
    {
        //Read Line Item 
        Console.WriteLine("Enter a Character");
        int lineItem = Console.Read();
        Console.WriteLine(lineItem);
        var lineItem2 = Convert.ToChar(lineItem);
        Console.WriteLine(lineItem2);

        //Console.ReadKey
        ConsoleKeyInfo enteredKey;

        do
        {
            enteredKey = Console.ReadKey();
            Console.WriteLine($"You pressed the {enteredKey.Key.ToString()} key");

        } while (enteredKey.Key != ConsoleKey.Escape);

        //Console.ReadLine
        string sentence;

        do
        {
            Console.WriteLine("Type in a sentence (or type quit to escape) Press enter when done.");
            sentence = Console.ReadLine();
            Console.WriteLine($"You entered the sentence: {sentence}");

        } while (sentence != "quit");


    }
}