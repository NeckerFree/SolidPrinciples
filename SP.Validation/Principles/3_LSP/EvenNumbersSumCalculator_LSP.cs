namespace SP.Validation.Principles._3_LSP
{
    public class EvenNumbersSumCalculator_LSP : SumCalculator_LSP
    {
        public EvenNumbersSumCalculator_LSP(int[] numbers)
            : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(x => x % 2 == 0).Sum();

    }
}

