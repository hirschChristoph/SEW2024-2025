Console.Write("    ");
for (int i = 1; i <= 10; i++)
{
    Console.Write("{0,4}", i);
}
Console.WriteLine();

for (int i = 1; i <= 10; i++)
{
    Console.Write("{0,4}", i);

    for (int j = 1; j <= 10; j++)
    {
        Console.Write("{0,4}", i * j);
    }

    Console.WriteLine();
}