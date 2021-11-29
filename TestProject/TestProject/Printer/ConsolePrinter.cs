namespace TestProject.Printer
{
    /// <summary>
    /// Реализация вывода в консоль
    /// </summary>
    internal class ConsolePrinter : IPrinter
    {
        /// <inheritdoc />
        public void Write(string srt)
        {
            Console.WriteLine(srt);
        }

        /// <inheritdoc />
        public void WriteArray<T>(IEnumerable<T> array)
        {
            foreach (var a in array)
                Console.Write($"{a} ");

            Console.WriteLine();
        }
    }
}
