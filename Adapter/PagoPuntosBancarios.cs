namespace Adapter
{
    internal class PagoPuntosBancarios : IPago
    {
        private readonly string _numTarjeta;
        public PagoPuntosBancarios(string numTarjeta)
        {
            _numTarjeta = numTarjeta;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando con puntos bancarios, tarjeta terminación {_numTarjeta}");
        }
    }
}
