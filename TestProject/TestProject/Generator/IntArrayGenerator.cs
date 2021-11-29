namespace TestProject.Generator
{
    /// <summary>
    /// Генератор массива целых чисел
    /// </summary>
    internal class IntArrayGenerator : IArrayGenerator<int>
    {
        /// <inheritdoc />
        public int[] GenerateRandom(int length)
        {
            var randNum = new Random();
            return Enumerable
                .Repeat(0, length)
                .Select(i => randNum.Next(-length, length))
                .ToArray();
        }

        /// <inheritdoc />
        public int[] GenerateReverse(int length)
        {
            return Enumerable.Range(0, length).Reverse().ToArray();
        }
    }
}
