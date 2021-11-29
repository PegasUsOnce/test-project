namespace TestProject.Sort
{
    /// <summary>
    /// Сортировка
    /// </summary>
    public interface ISort
    {
        /// <summary>
        /// Выполнить сортировку
        /// </summary>
        IReadOnlyCollection<T> Execute<T>(IReadOnlyCollection<T> items) where T : IComparable<T>;
    }
}
