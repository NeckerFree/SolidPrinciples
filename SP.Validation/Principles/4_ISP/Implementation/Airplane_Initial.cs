namespace SP.Validation.Principles._4_ISP.Implementation
{
    internal class Airplane_Initial : IVehicle_Initial
    {
        public void Drive()
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Fly an airplane");
        }
    }
}
