// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 0; i < 1000; i++)
{
    await Task.Delay(1000);
    Console.WriteLine("current "+i+" -> 1000");
}
Console.WriteLine("end");
