

using BookApp2.App.Services.Implementations;

BookService book = new BookService();

Console.WriteLine("0.Stop proqram");
Console.WriteLine("1.Create book");
Console.WriteLine("2.Show books");

string command = Console.ReadLine();
while (command!="0")
{
	switch (command)
	{
		case "1":
			book.Create();
			break;
		case "2":
			book.ShowAll();
			break;
		default:
			Console.WriteLine("Command not true");
			break;
	}
    Console.WriteLine("0.Stop proqram");
    Console.WriteLine("1.Create book");
    Console.WriteLine("2.Show books");
	

    command = Console.ReadLine();
}