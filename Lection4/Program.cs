// Двумерные массивы

string[,] table = new string [2,5];
table[1, 2] = "слово";


for (int rows = 0; rows < length; rows++)
{
    for (int columns = 0; columns < length; columns++)
    {
        Consol.WriteLine ($"{table[row,columns]}")
    }
}

