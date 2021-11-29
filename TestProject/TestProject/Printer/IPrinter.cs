namespace TestProject.Printer
{
    /// <summary>
    /// Вывод
    /// </summary>
    public interface IPrinter
    {
        /// <summary>
        /// Вывести строку
        /// </summary>
        void Write(string srt);

        /// <summary>
        /// Вывести массив
        /// </summary>
        void WriteArray<T>(IEnumerable<T> array);
    }
}
