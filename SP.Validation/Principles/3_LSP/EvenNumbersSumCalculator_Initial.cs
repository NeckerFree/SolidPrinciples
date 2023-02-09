namespace SP.Validation.Principles._3_LSP
{
    public class EvenNumbersSumCalculator_Initial : SumCalculator_Initial
    {
        public EvenNumbersSumCalculator_Initial(int[] numbers)
            : base(numbers)
        {
        }

        public new int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();
    }
}
