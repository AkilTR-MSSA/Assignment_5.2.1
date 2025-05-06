Console.WriteLine(LastWordLength("Hello World"));
Console.WriteLine(LastWordLength("fly me to the moon"));

int LastWordLength(string input)
{
    string[] s = input.Split(' ');
    return s[s.Length - 1].Length;
}