namespace SP.Validation.Principles._3_LSP
{

    public abstract class Calculator_LSP
    { 
        protected readonly int[] _numbers;

        public Calculator_LSP(int[] numbers)
        {
            _numbers = numbers;
        }

        public abstract int Calculate();
    }
}
