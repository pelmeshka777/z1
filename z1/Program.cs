// See https://aka.ms/new-console-template for more information


var LatinChars =  new char [] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F',
    'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

var fileContent = File.ReadAllText("D:\\test.txt");

Console.Write(fileContent);
Console.WriteLine();

bool IsLatin(char el)
{
    foreach (var latin in LatinChars)
    {
        if (latin == el) return true;
    }
    return false;
}
 int sumChars = 0;
string someLetters = fileContent;
for (int i = 0; i < someLetters.Length; i++)
{
    if (IsLatin(someLetters[i]) == true)
    {
        sumChars++;
    }
   
} Console.WriteLine(sumChars);

char space = ' ';
int sumSpaces = 0;
for (int j = 0; j < someLetters.Length; j++)
{
    if (j == 0 && someLetters[0] == space) continue;
    if (space == someLetters[j] && IsLatin(someLetters[j + 1]) && IsLatin(someLetters[j - 1]))
    {
        sumSpaces++;
    }
} Console.WriteLine(sumSpaces);