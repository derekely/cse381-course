namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        /*
         * Set p (first) to 0, and set r (last) to n (last).
         * While p <= r, do the following:
         *   Set q to [(p + r) / 2], rounding down.
         *   If A[q] == x, the search is done; return q.
         *   If A[q] > x, set r to q - 1.
         *   If A[q] < x, set p to q + 1.
         * If the search is done (p > r), return -1 (not found).
         */

        int first = 0;
        int last = data.Count - 1;
        
        //if (first > last || last == 0) return -1;
        
        while (first <= last)
        {
            int middle = (int)Math.Floor(((float)first + last) / 2);
            if (data[middle].Equals(target))
            {
                return middle;
            }
            if (data[middle].CompareTo(target) > 0)
            {
                last = middle - 1;
            }
            if (data[middle].CompareTo(target) < 0)
            {
                first = middle + 1;
            }
        }
        return -1;
    }
}