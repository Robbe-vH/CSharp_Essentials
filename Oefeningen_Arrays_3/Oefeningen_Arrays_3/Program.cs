// Oefening 1

static int[] ToArray(int a, int b)
{
    int[] result = new int[] { a, b };
    return result;
    }

// Oefening 3
string[] reeks = new string[] { "1", "2", "3", "4" };

static double[] ConvertToDouble(string[] reeks)
{
    double[] result = new double[reeks.Length];
    for (int i = 0; i < reeks.Length; i++)
    {
        if (double.TryParse(reeks[i], out double getal))
        {
            result[i] = getal;
        }
        else
        {
            throw new FormatException("Het getal is niet converteerbaar.");
        }
    }
    return result;
}

ConvertToDouble(reeks);