namespace SP.Validation.Principles._3_LSP
{
    public class SumCalculator_LSP: Calculator_LSP
    {
        public SumCalculator_LSP(int[] numbers) : base(numbers)
        {
            
        }

        public override int Calculate() => _numbers.Sum();

      
    }
}
