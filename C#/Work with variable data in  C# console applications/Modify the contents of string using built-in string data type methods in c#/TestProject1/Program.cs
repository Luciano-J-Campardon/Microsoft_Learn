const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// Your work here
const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingSpan = input.IndexOf(openSpan);
int closingSpan = input.IndexOf(closeSpan);

openingSpan += openSpan.Length;
int length = closingSpan - openingSpan;

string quantity = input.Substring(openingSpan, length);
string output = input.Replace("<div>", "").Replace("</div>", "").Replace("&trade", "&reg"); 

Console.WriteLine("");
Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
Console.WriteLine("");