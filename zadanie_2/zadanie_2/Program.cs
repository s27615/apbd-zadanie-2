// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

static double GetAverage(int[] tab)
{
    int suma = 0;
    foreach (var number in tab)
    {
        suma += number;
    }
    
    return (double) suma / tab.Length;
}

int[] tablica = {1, 2, 3, 5};
double average = GetAverage(tablica);
Console.WriteLine(average);

public static int max(int[] tab)
{
    int max = tab[0];
    for (int i = 0; i < tab.Length; i++)
    {
        if (tab[i] > max)
            max = tab[i];
    }

    return max;
}