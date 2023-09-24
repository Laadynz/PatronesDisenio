namespace Adapter
{
    internal class PagoPaypal : IPago
    {
        private readonly string _numReferencia;
        public PagoPaypal(string numReferencia)
        {
            _numReferencia = numReferencia;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando por medio de PayPal, con numero de referencia {_numReferencia}");
        }
    }
}
