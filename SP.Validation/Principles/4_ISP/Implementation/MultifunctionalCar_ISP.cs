using SP.Validation.Principles._4_ISP.Interface;

namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class MultifunctionalCar_ISP : ICar_ISP, IAirplane_ISP
    {
        public void Drive()
        {
            Console.WriteLine("Drive a multifuctional car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly a multifunctional car");
        }
    }
}
