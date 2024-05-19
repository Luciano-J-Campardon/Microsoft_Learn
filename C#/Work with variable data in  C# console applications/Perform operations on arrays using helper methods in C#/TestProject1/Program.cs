using System.Data;
using System.Runtime.CompilerServices;

string pangram = "The quick brown fox jumps over the lazy dog";
string[] textArray = pangram.Split(" ");
string[] reversePangram = new string[textArray.Length];

for (int i = 0; i < textArray.Length; i++)
{
    string blankTest = textArray[i];
    char[] charsArray = blankTest.ToCharArray();
    Array.Reverse(charsArray);
    string reverseText = string.Join("", charsArray);
    reversePangram[i] = reverseText;
}

Console.WriteLine(string.Join(" ", reversePangram));

