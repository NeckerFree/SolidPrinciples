using SP.Validation.Principles._4_ISP.Interface;

namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class Airplane_ISP : IAirplane_ISP
    {
        public void Fly()
        {
            Console.WriteLine("Fly and airplane");
        }
    }
}
