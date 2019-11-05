using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public abstract class Cuenta
    {
        public Cuenta()
        {

        }

        public string Numero { get; set; }

        public decimal Saldo { get; set; }

        public Cliente Cliente { get; set; }

        public List<Transaccion> Transacciones { get; }

        public abstract bool Consignar(decimal amount);

        public abstract bool Retirar(decimal amount);

        public void RegistrarTransaccion(decimal amount)
        {
            Transacciones.Add(new Transaccion(amount));
        }
    }
}
