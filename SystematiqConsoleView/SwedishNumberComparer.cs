using System.Globalization;

namespace SystematiqConsoleView;
public class SwedishNumberHelper
{
    public string[] swedishNumbers = new string[25];

    public SwedishNumberHelper()
    {
        swedishNumbers[0] = "Ett";
        swedishNumbers[1] = "Två";
        swedishNumbers[2] = "Tre";
        swedishNumbers[3] = "Fyra";
        swedishNumbers[4] = "Fem";
        swedishNumbers[5] = "Sex";
        swedishNumbers[6] = "Sju";
        swedishNumbers[7] = "Åtta";
        swedishNumbers[8] = "Nio";
        swedishNumbers[9] = "Tio";
        swedishNumbers[10] = "Elva";
        swedishNumbers[11] = "Tolv";
        swedishNumbers[12] = "Tretton";
        swedishNumbers[13] = "Fjorton";
        swedishNumbers[14] = "Femton";
        swedishNumbers[15] = "Sexton";
        swedishNumbers[16] = "Sjutton";
        swedishNumbers[17] = "Arton";
        swedishNumbers[18] = "Nitton";
        swedishNumbers[19] = "Tjugo";
        swedishNumbers[20] = "Tjugoen";
        swedishNumbers[21] = "Tjugotvå";
        swedishNumbers[22] = "Tjugotre";
        swedishNumbers[23] = "Tjugofyra";
        swedishNumbers[24] = "Tjugofem";
    }

    public List<Tuple<string, int>> SortNumbersInSwedish(List<int> numbers)
    {
        CultureInfo swedishCulture = CultureInfo.CreateSpecificCulture("sv-SE");
        var tuples = new List<Tuple<string, int>>();
        foreach (int number in numbers)
        {
            tuples.Add(new Tuple<string, int>(swedishNumbers[number - 1], number));
        }
        IComparer<Tuple<string, int>> comparer = Comparer<Tuple<string, int>>.Create((x, y) => string.Compare(x.Item1, y.Item1, true, swedishCulture));
        tuples.Sort(comparer);
        return tuples;
    }
}