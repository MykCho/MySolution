// See https://aka.ms/new-console-template for more information
do
{
    Console.Write("\nPress the number [1-7] and get the corresponding day of the week: ");
    switch (Console.ReadKey().Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine(" - Monday");
            break;
        case ConsoleKey.D2:
            Console.WriteLine(" - Tuesday");
            break;
        case ConsoleKey.D3:
            Console.WriteLine(" - Wednesday");
            break;
        case ConsoleKey.D4:
            Console.WriteLine(" - Thursday");
            break;
        case ConsoleKey.D5:
            Console.WriteLine(" - Friday");
            break;
        case ConsoleKey.D6:
            Console.WriteLine(" - Saturday");
            break;
        case ConsoleKey.D7:
            Console.WriteLine(" - Sunday");
            break;
        default:
            Console.WriteLine(" - !Nonsence!\b");
            break;
    }
    Console.Write("Again? N to exit, any other key to continue: ");
} while (Console.ReadKey().Key != ConsoleKey.N);
