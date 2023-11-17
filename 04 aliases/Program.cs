
using Beer = (string name, decimal price);
Beer beer = new Beer() { name = "Corona", price = 18 };
Console.WriteLine(beer.name);
Console.WriteLine(beer.price);