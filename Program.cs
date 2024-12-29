string[,] corporate =
{
    {"Robert", "Bavin"},
    {"Simon", "Bright"},
    {"Kim", "Sinclair"},
    {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"},
    {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
    DisplayCorporateEmail(corporate[i, 0], corporate[i, 1]);
}

for (int i = 0; i < external.GetLength(0); i++)
{
    DisplayExternalEmail(external[i, 0], external[i, 1]);
}

void DisplayCorporateEmail(string name, string lastName)
{
    Console.WriteLine($"{name.Substring(0, 2).ToLower()}{lastName.ToLower()}@contoso.com");
}

void DisplayExternalEmail(string name, string lastName)
{
    Console.WriteLine($"{name.Substring(0, 2).ToLower()}{lastName.ToLower()}@contoso.com");
}