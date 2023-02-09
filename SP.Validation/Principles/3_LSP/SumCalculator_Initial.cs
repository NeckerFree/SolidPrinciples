using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.Validation.Principles._3_LSP
{
    public class SumCalculator_Initial
    {
        protected readonly int[] _numbers;

        public SumCalculator_Initial(int[] numbers)
        {
            _numbers = numbers;
        }

        public int Calculate() => _numbers.Sum();
    }
}
