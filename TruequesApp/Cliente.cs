using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruequesApp
{
    internal class Cliente
    {

        public string Nombre { get; set; }
        public string Rut { get; set; }
        public int Fono { get; set; }

        public Cliente(string nombre, string rut, int fono)
        {
            Nombre = nombre;
            Rut = rut;
            Fono = fono;
        }

        public void MostrarCliente()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Cliente:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Nombre);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Rut:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Rut);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Fono:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Fono + "\n");
            Console.ForegroundColor = ConsoleColor.Gray;

        }
    }
}
