using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Cliente
    {
        public Cliente(string id, string nombre)
        {
            ID = id;
            Nombre = nombre;
        }

        public string ID { get; set; }

        public string Nombre { get; set; }
    }
}
