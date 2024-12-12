/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int letterCount = 0;
foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        letterCount++; 
    }
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");