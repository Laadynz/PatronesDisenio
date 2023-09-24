namespace Adapter
{
    internal class PagoCheque : IPago
    {
        private readonly string _numCheque;
        public PagoCheque(string numCheque)
        {
            _numCheque = numCheque;
        }

        public void Cobrar()
        {
            Console.WriteLine($"Pagando con cheque, terminación {_numCheque}");
        }
    }
}
