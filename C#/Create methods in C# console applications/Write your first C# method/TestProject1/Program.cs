/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

string[] ipArray = new string[5];
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

for (int i = 0; i < ipArray.Length; i++)
{
    string randomIp = CreateIPv4Adress();
    ipArray[i] = randomIp;
}

foreach (string ip in ipArray)
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength();
    ValidateZeroes();
    ValidateRange();

    if (validLength && validZeroes && validRange)
    {
        Console.WriteLine($"The ip {ip} is a valid IPv4 address");
    }
    else
    {
        Console.WriteLine($"The ip {ip} is an invalid IPv4 address");
    }
}

void ValidateLength()
{
    validLength = address.Length == 4;
}

void ValidateZeroes()
{
    foreach (string number in address)
    {
        if (number.Length > 1 && number.StartsWith("0"))
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange()
{
    foreach (string number in address)
    {
        int value = int.Parse(number);
        if (value < 0 || value > 255)
        {
            validRange = false;
            return;
        }
    }

    validRange = true;
}

string CreateIPv4Adress()
{
    Random random = new Random();
    int[] ipv4parts = new int[4];

    for (int i = 0; i < ipv4parts.Length; i++)
    {
        ipv4parts[i] = random.Next(0, 256);
    }

    string ipv4ip = string.Join(".", ipv4parts);
    return ipv4ip;
};
