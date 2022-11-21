static void Uitleg()
{
    Console.Write("Geef ee ngettal om te verdubbelen: ");

    string input = Console.ReadLine();
    int getal = 0;

    try
    {
        getal = Convert.ToInt32(input);
    }
    catch (FormatException e)
    {
        Console.WriteLine("De input was geen getal, default waarde 0 wordt gebruikt");
        Console.WriteLine(e.Message);
    }
    catch (DivideByZeroException e)
    {
        Console.WriteLine("De meest specifieke exception van arithmics");
        Console.WriteLine(e.Message);
    }
    catch (SystemException e)
    {
        Console.WriteLine("Algemener dan divide by 0");
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine("Meest algemene fout");
        Console.WriteLine(e.Message);
    }
    finally
    {
        Console.WriteLine($"het verdubbelde getal is: {getal * 2}");
        Console.WriteLine("Fijne dag nog");
    }
}


static int VraagInputVangetal(string vraag)
{
    Console.WriteLine(vraag);
    int getal;
    if (int.TryParse(Console.ReadLine(), out getal))
    {
        return getal;
    }
    else
    {
        throw new FormatException("De ingegeven waarde is geen getal!");
    }
}
try
{
    int gebruikerGetal = VraagInputVangetal("Geef een getal: ");
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}


