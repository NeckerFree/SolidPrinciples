namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class Car_Initial : IVehicle_Initial
    {
        public void Drive()
        {
            Console.WriteLine("Drive a car");
        }

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
