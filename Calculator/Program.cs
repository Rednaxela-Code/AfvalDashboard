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

// Original method from assignment. My problems with tis are, Avarage is not the right spelling, why use list name "ints" when list is perfectly readable in such a small function. Why return Null in the exception? I do not get why this would be good ??
float? Avarage(List<int> ints)
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

// My own refactor for "Readability", with a nullcheck so trycatch block should not be needed as far as i know.
float? Average(List<int> list)
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

// Refactor with some internet, changed returntype to Double, the internet tells me it is more accurate. Dunno , LINQ should be faster? Readability is still great for such a small function.
double? AverageLinq(List<int> ints)
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

// This one from the assignment does not work, as far as i know it should be the class that is abstract. Also i would change the Class name to DataEntity, i think a class named Identity will give big problems when you want to scaffolt EFCORE.Identity

//public class Identity
//{
//    public abstract int Id { get; set; }
//}
public abstract class DataEntity()
{
    public int Id { get; set; }
}