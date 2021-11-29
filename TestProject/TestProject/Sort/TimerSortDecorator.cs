using System.Diagnostics;
using TestProject.Printer;

namespace TestProject.Sort
{
    /// <summary>
    /// Декоратор сортировки для измерения времени выполнения
    /// </summary>
    public class TimerSortDecorator<TSort>: ISort
        where TSort : ISort, new()
    {
        private readonly ISort _sort;
        private readonly IPrinter _printer;

        /// <summary>
        /// ctor
        /// </summary>
        public TimerSortDecorator(
            IPrinter printer)
        {
            _printer = printer;
            _sort = new TSort();
        }

        /// <inheritdoc />
        public IReadOnlyCollection<T> Execute<T>(IReadOnlyCollection<T> items) where T : IComparable<T>
        {
            var timer = new Stopwatch();
            timer.Start();

            var result = _sort.Execute(items);

            timer.Stop();

            _printer.Write("Before:");
            _printer.WriteArray(items);
            _printer.Write("After:");
            _printer.WriteArray(result);
            _printer.Write($"Sort time of {_sort.GetType().Name}: {timer.Elapsed}");

            return result;
        }
    }
}
