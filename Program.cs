string pangram = "The quick brown fox jumps over the lazy dog";
string[] strings = pangram.Split(" ");
foreach (string s in strings)
{
    char[] chars= s.ToCharArray();
    Array.Reverse(chars);
    foreach (char c in chars)
        Console.Write(c);
    Console.Write(" ");
}