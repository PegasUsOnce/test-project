namespace TestProject.Sort
{
    /// <summary>
    /// Обычная сортировка пузырьком
    /// </summary>
    internal class BubbleSort : ISort
    {
        /// <inheritdoc />
        public IReadOnlyCollection<T> Execute<T>(IReadOnlyCollection<T> items) 
            where T : IComparable<T>
        {
            var length = items.Count;
            var result = items.ToArray();

            for (var i = 0; i < length; i++)
            {
                for (var sort = 0; sort < length - 1; sort++)
                {
                    if (result[sort].CompareTo(result[sort + 1]) == 1)
                    //if (result[sort] > result[sort + 1])
                        Swap(sort, sort + 1, result);
                }
            }

            return result;
        }

        private static void Swap<T>(int xi, int yi, T[] items)
        {
            var temp = items[xi];
            items[xi] = items[yi];
            items[yi] = temp;
        }
    }
}
