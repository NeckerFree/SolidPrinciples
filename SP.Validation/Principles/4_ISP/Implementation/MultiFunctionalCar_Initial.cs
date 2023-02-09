namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class MultiFunctionalCar_Initial : IVehicle_Initial
    {
        public void Drive()
        {
            Console.WriteLine("Drive Multifunctional Car");
        }

        public void Fly()
        {
            Console.WriteLine("Fly Multifuctional Car");
        }
    }
}
