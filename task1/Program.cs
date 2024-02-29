char[,] symbol = new char[,]
{
    {'a', 'b'},
    {'d', 'e'},
};

string result = string.Empty;

for (int i = 0; i < symbol.GetLength(0); i++)
{
    for (int j = 0; j < symbol.GetLength(1); j++)
    {
        result += symbol[i, j];
    }
}

Console.WriteLine(result);