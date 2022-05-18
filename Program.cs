
using HandlingError;


Console.Clear();

FileReader fileReader = new FileReader();

do
{

    Console.Write("Enter file name to read or type quit to exit : ");
    string input = Console.ReadLine() ?? "";

    if (input.Equals("quit")) break;

    try
    {
        fileReader.ReadFile(input);
    }
    catch (FileEmptyException)
    {
        Console.WriteLine("File is empty.");
    }


} while (true);

Console.WriteLine("GoodBye!");