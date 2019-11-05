using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Transaccion
    {
        public Transaccion(decimal amount)
        {
            Date = DateTime.Now;
            Amount = amount;
        }

        public DateTime Date { get; }

        public decimal Amount { get; }

        public override string ToString()
        {
            return $"Fecha: {Date.ToString("dd/MM/yyyy hh:mm:ss tt")}, Cantidad: {Amount.ToString("+0.00 : Consignación;-0.00 : Retiro;Cero")}";
        }
    }
}
