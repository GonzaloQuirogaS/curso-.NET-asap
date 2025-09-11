using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class PagoPaypal : Pago, INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"[Notificacion paypal] {mensaje}");
        }

        public override void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago en paypal - Monto: {monto}");
            Notificar($"Pago con paypal");
        }
    }
}
