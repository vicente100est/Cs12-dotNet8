var beer1 = new Beer("Corona");
Console.WriteLine(beer1.Name);

public class Beer(string _name)
{
    public string Name = _name.ToUpper();
}

//Tradicional

//var beer1 = new Beer("Corona");
//Console.WriteLine(beer1);

//public class Beer(string _name)
//{
//    public string Name { get; set; }
//    public Beer(string name)
//    {
//        Name = name.ToUpper();
//    }
//}