namespace Adapter
{
    internal class PagoTarjetaVales : IPago
    {
        private readonly string _numTarjeta;
        public PagoTarjetaVales(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }
        public void Cobrar()
        {
            Console.WriteLine($"Pagando con tarjeta de vales terminación {_numTarjeta}");
        }

    }
}
