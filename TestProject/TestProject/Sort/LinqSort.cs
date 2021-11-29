namespace TestProject.Sort
{
    /// <summary>
    /// Сортировка LINQ
    /// </summary>
    internal class LinqSort : ISort
    {
        /// <inheritdoc />
        public IReadOnlyCollection<T> Execute<T>(IReadOnlyCollection<T> items)
             where T : IComparable<T>
        {
            return items.OrderBy(x => x).ToArray();
        }
    }
}
