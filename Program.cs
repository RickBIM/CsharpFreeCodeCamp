string myIntString = "hello";
if (int.TryParse(myIntString, out int myIntNumber))
	Console.WriteLine(myIntNumber);
else
	Console.WriteLine("Não foi possivel converter");