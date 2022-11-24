﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TruequesApp
{
    internal class Producto
    {
        public int CodigoProducto { get; set; }
        public DateTime FechaIngreso { get; set; }
        public string Descripcion { get; set; }
        public int ValorAproximado { get; set; }
        public string[] Preferencias { get; set; }
        public bool Disponible { get; set; }
        public string ClienteId { get; set; }

        public Producto(int codigoProducto, string clienteId, DateTime fechaIngreso, string descripcion, int valorAproximado, string[] preferencias, bool disponible)
        {
            CodigoProducto = codigoProducto;
            FechaIngreso = fechaIngreso;
            Descripcion = descripcion;
            ValorAproximado = valorAproximado;
            Preferencias = preferencias;
            Disponible = disponible;
            ClienteId = clienteId;
        }

        public void MostrarProducto()
        {
            string strDisponible;
            if (Disponible)
            {
                strDisponible = "Sí";
            }
            else
                strDisponible = "No";

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("Codigo:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(CodigoProducto);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Cliente:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ClienteId);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|FechaIngreso:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(FechaIngreso);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Descripcion:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Descripcion);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Valor Aproximado:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(ValorAproximado);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|Preferencias:");

            int contador = 0;
            foreach (string preferencias in Preferencias)
            {
                contador++;
                Console.ForegroundColor = ConsoleColor.White;
                if (Preferencias.Length != contador)
                {
                    Console.Write(preferencias + "-");
                }
                else
                {
                    Console.Write(preferencias);
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("|");
            if (Disponible)
            {
                Console.ForegroundColor = ConsoleColor.Green;//Esto es un agregado cambia el color de disponible en consola
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            Console.Write("Disponible:{0}", strDisponible);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Environment.NewLine);

        }
    }
}
