using System.Security;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string internalDomain = "@contoso.com";

DisplayEmailAddresses(corporate, external);

void DisplayEmailAddresses(string[,] corpoArray, string[,] extArray, string domain = "@hayworth.com")
{
    string partialEmail = "";

    for (int i = 0; i < corporate.GetLength(0); i++)
    {
        if (corporate[i, 0].Equals(corpoArray[i, 0]))
        {
            partialEmail = ((corpoArray[i, 0].ToString()).Substring(0, 2) + corpoArray[i, 1]).ToLower();
            Console.WriteLine($"{partialEmail + internalDomain}");
        }
    }

    for (int i = 0; i < external.GetLength(0); i++)
    {
        if (external[i, 0].Equals(extArray[i,0]))
        {
            partialEmail = ((extArray[i, 0].ToString()).Substring(0,2) + extArray[i, 1]).ToLower();
            Console.WriteLine($"{partialEmail + domain}");

        }
    }
}

