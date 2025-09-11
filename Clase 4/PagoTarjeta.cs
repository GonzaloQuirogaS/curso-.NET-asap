using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clase_4
{
    internal class PagoTarjeta : Pago, INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine($"[Notificacion tarjeta] {mensaje}");
        }

        public override void ProcesarPago(double monto)
        {
            Console.WriteLine($"Procesando pago en tarjeta - Monto: {monto}");
            Notificar($"Pago con tarjeta");
        }
    }
}
