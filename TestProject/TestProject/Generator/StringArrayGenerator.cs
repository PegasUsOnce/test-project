namespace TestProject.Generator
{
    /// <summary>
    /// Генератор массива строк
    /// </summary>
    internal class StringArrayGenerator: IArrayGenerator<string>
    {
        /// <summary>
        /// Максимальная длина строки
        /// </summary>
        private readonly int _maxLength;
        public StringArrayGenerator(int maxLength = 12)
        {
            _maxLength = maxLength;
        }

        const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        /// <inheritdoc />
        public string[] GenerateRandom(int length)
        {
            var randomLength = new Random();
            var randomChar = new Random();
            return Enumerable
                .Repeat(0, length)
                .Select(i => randomLength.Next(1, _maxLength))
                .Select(l => new string(Enumerable.Repeat(1, l)
                    .Select(s => Chars[randomChar.Next(Chars.Length)]).ToArray()))
                .ToArray();
        }

        /// <inheritdoc />
        public string[] GenerateReverse(int length)
        {
            var randomLength = new Random();
            var randomChar = new Random();
            return Enumerable
                .Repeat(0, length)
                .Select(i => randomLength.Next(1, _maxLength))
                .Select(l => new string(Enumerable.Repeat(1, l)
                    .Select(s => Chars[randomChar.Next(Chars.Length)]).ToArray()))
                .OrderByDescending(s => s)
                .ToArray();
        }
    }
}
