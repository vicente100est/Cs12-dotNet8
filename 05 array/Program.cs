var beers = new Beers();

for (int i = 0; i < 10; i++)
{
    beers[i] = "Some";
}

foreach (var beer in beers)
{
    Console.WriteLine(beer);
}

// Array Limit
[System.Runtime.CompilerServices.InlineArray(10)]

public struct Beers
{
    private string _name;
}