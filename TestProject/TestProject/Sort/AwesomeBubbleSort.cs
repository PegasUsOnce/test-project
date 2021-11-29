namespace TestProject.Sort
{
    /// <summary>
    /// Сортировка пузырьком с уменьшенным кол-вом перестановок
    /// </summary>
    internal class AwesomeBubbleSort : ISort
    {
        /// <inheritdoc />
        public IReadOnlyCollection<T> Execute<T>(IReadOnlyCollection<T> items)
            where T : IComparable<T>
        {
            var length = items.Count;
            var result = items.ToArray();

            for (var i = 0; i < length; i++)
            {
                var minIndex = i;
                for (var sort = i + 1; sort < length; sort++)
                {
                    if (result[minIndex].CompareTo(result[sort]) == 1)
                        minIndex = sort;                        
                }

                Swap(i, minIndex, result);
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
