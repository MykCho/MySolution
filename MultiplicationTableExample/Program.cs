void printMultTable(int number) //here's our function
{
    for (int i = 2; i < 10; i++)
    {
        Console.WriteLine($"{number}*{i} = {i * number}");
    }
}

//here goes the main part
int keyAscii = 50;//ASCII code between 48 and 58

Console.Write("Press a key [1-9] to view the corresponding multiplication table, ESC or ENTER to exit: ");
while (keyAscii != 27 && keyAscii != 13) //ASCII code of ESC and ENTER
{
    keyAscii = Console.ReadKey().KeyChar; //implicit cast from Char to Int
    Console.Write('\n');
    if (keyAscii > 48 && keyAscii < 58) printMultTable(keyAscii - 48); //here 48 is the offset between digits and their ASCII code
    else Console.WriteLine("Incorrect input");
}
