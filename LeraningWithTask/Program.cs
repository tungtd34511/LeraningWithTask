// See https://aka.ms/new-console-template for more information
Console.WriteLine(DateTime.Now);
await Task.Delay(5000);
await Task.Run(() =>
{
    Console.WriteLine(DateTime.Now);
});
