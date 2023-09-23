namespace AlgorithmLib;

    public static class BetterLinearSearch
    {
        /// <summary>
        /// Loop through the list and check if the current element is equal to the target
        /// </summary>
        /// <param name="data">List of your data</param>
        /// <param name="target">Item you want to check is in the Data</param>
        /// <returns>Index of target if it is in the data, if not return -1</returns>
        public static int Search(List<IComparable> data, IComparable target)
        {
            int index = -1;
            int times = 0;
            
            foreach (var singleData in data)
            {
                times++;
                if (singleData.Equals(target))
                {
                    index = data.IndexOf(singleData);
                    break;
                }
            }
            Console.WriteLine(times);
            return index;
        }
    }