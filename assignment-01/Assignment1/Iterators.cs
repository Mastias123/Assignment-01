namespace Assignment1;

public static class Iterators
{
    public static IEnumerable<T> Flatten<T>(IEnumerable<IEnumerable<T>> items)
    {
        foreach (IEnumerable<T> item  in items)
        {
            foreach(var i in item)
            {
                yield return i;
            }
        }
    }
    public static IEnumerable<T> Filter<T>(IEnumerable<T> items, Predicate<T> predicate)
    { 
        //List<T> filterList = new List<T>();
        foreach (T item  in items)
        {
            if(predicate.Invoke(item))
            {
                //filterList.Add(item);
                yield return item;
            }
        }
        //return filterList.AsEnumerable<T>();
    }
}