int[,] juist = new int[2, 2]
{
    {0,1},
    {2,3}
};

Random[,] GridVanRandoms = new Random[3, 4];

int[,] gridVanGetallen = new int[3, 4]
{
    {0,0,23,1},
    {1,0,2,34},
    {2,0,65,-123}
};

int totaalAantalElementen = GridVanRandoms.Length;
int aantalRijen = GridVanRandoms.GetLength(0);
int aantalKolommen = GridVanRandoms.GetLength(1);

for (int  i = 0;  i < GridVanRandoms.GetLength(0) ;  i++)
{
    for (int j = 0; j < GridVanRandoms.GetLength(1); j++)
    {
        Console.WriteLine(GridVanRandoms[i,j]);
    }
}

int grootsteGetal = int.MinValue;
int kleinsteGetal = int.MaxValue;

for (int i = 0; i < gridVanGetallen.GetLength(0); i++)
{
    for (int j = 0; j < gridVanGetallen.GetLength(1); j++)
    {
        if (gridVanGetallen[i,j] < kleinsteGetal)
        {
            kleinsteGetal = gridVanGetallen[i, j];
        }
        if (gridVanGetallen[i,j] > grootsteGetal)
        {
            grootsteGetal = gridVanGetallen[i, j];
        }
    }
}
