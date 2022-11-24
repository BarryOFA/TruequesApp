using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruequesApp
{
    internal class Operacion
    {
        public int IdOperacion { get; set; }
        public string IdCliente { get; set; }
        public int IdProducto { get; set; }
        public string TipoOperacion { get; set; }
        public DateTime fechaOperacion { get; set; }

        public Operacion(int idOperacion, DateTime fechaOperacion, string tipoOperacion, string idCliente, int idProducto)
        {
            IdOperacion = idOperacion;
            IdCliente = idCliente;
            IdProducto = idProducto;
            TipoOperacion = tipoOperacion;
            this.fechaOperacion = fechaOperacion;
        }

        public void MostrarOperacion()
        {
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("Fecha Operacion:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(fechaOperacion);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("|TipoOperacion:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(TipoOperacion);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("|IdCliente:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(IdCliente);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write("|IdProducto:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(IdProducto + "\n");
                Console.ForegroundColor = ConsoleColor.Gray;

            }


        }
    }
}
