namespace TestProject.Generator
{
    /// <summary>
    /// генератор массива
    /// </summary>
    public interface IArrayGenerator<T>
    {
        /// <summary>
        /// Сгенерировать массив случайных значений
        /// </summary>
        public T[] GenerateRandom(int length);

        /// <summary>
        /// Сгенерировать массив значений, отсортированных в обратном порядке
        /// </summary>
        public T[] GenerateReverse(int length);
    }
}
