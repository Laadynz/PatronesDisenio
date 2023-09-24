using Adapter;

IPago pago = new PagoTransferencia();
Ventas venta = new Ventas(pago);
venta.ProcesarPago();

IPago pago1 = new PagoEfectivo();
Ventas venta1 = new Ventas(pago1);
venta1.ProcesarPago();

IPago pagoTC = new PagoTarjetaCredito("0123");
Ventas ventaTC = new Ventas(pagoTC);
ventaTC.ProcesarPago();

IPago pagoTD = new PagoTarjetaDebito("456");
Ventas ventaTD = new Ventas(pagoTD);
ventaTD.ProcesarPago();

IPago pagoTV = new PagoTarjetaVales("0000");
Ventas ventaTV = new Ventas(pagoTV);
ventaTV.ProcesarPago();

IPago pagoPB = new PagoPuntosBancarios("211288");
Ventas ventaPB = new Ventas(pagoPB);
ventaPB.ProcesarPago();

IPago pagoCheque = new PagoCheque("78946");
Ventas ventaCheque = new Ventas(pagoCheque);
ventaCheque.ProcesarPago();

IPago pagoPaypal = new PagoPaypal("666");
Ventas ventaPaypal = new Ventas(pagoPaypal);
ventaPaypal.ProcesarPago();

Console.ReadKey();