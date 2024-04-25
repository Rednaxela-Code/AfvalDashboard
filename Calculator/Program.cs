var list = new List<int>();
for (int i = 0; i < 10; i++)
{
    list.Add(5);
}

var resultOne = Avarage(list);
Console.WriteLine(resultOne);

var resultTwo = Average(list);
Console.WriteLine(resultTwo);

var resultThree = AverageLinq(list);
Console.WriteLine(resultThree);

static float? Avarage(List<int> ints)
{
    try
    {
        int total = 0;
        foreach (var item in ints)
        {
            total += item;
        }
        return total / ints.Count;
    }
    catch (Exception)
    {
        return null;
    }
}

static float? Average(List<int> list)
{
    if (list == null)
    {
        return null;
    }
    if (list.Any())
    {
        int result = 0;
        foreach (var item in list)
        {
            result += item;
        }
        return result / list.Count;
    }
    return null;
}

static double? AverageLinq(List<int> ints)
{
    if (ints == null || ints.Count == 0)
    {
        return null;
    }
    else
    {
        return ints.Average();
    }
}

//public abstract class Identity
//{
//    public abstract int Id { get; set; }
//}

//public abstract class DataEntity
//{
//    public int Id { get; set; }
//}