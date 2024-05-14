string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

Dictionary<char, int> charCounts = [];

foreach (char letter in loremIpsum.ToUpper().ToCharArray())
{
    if (!charCounts.ContainsKey(letter) && char.IsLetter(letter))
    {
        charCounts.Add(letter, 1);
    }
    else if (char.IsLetter(letter))
    {
        charCounts[letter]++;
    }
}

foreach (KeyValuePair<char, int> entry in charCounts)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}