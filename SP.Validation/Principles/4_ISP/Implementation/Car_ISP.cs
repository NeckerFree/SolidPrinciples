using SP.Validation.Principles._4_ISP.Interface;

namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class Car_ISP : ICar_ISP
    {
        public void Drive()
        {
            Console.WriteLine("Drive a car");
        }
    }
}
