const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

int startPosition  = input.IndexOf("<span>") + "<span>".Length;
int endPosition = input.IndexOf("</span>");
int length = endPosition - startPosition;
quantity = input.Substring(startPosition, length);
Console.WriteLine(quantity);

startPosition  = input.IndexOf("<div>") + "<div>".Length;
endPosition = input.IndexOf("</div>");
length = endPosition - startPosition;
output = input.Substring(startPosition, length);
output = output.Replace("&trade", "&reg");
Console.WriteLine(output);