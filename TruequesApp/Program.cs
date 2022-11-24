
namespace TruequesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "0";
            do
            {
                LinqTrueques.RellenarListaProductos();
                LinqTrueques.RellenarListaCLientes();
                LinqTrueques.RellenarListaOperaciones();
                Console.ReadLine();
                Console.Clear();
                LinqTrueques.ConteoGeneral();
                Console.WriteLine(
                    "Ingrese su consulta seleccionando una opcion. \n" +
                    "(1)Agregar Cliente\n" +
                    "(2)Agregar Producto\n" +
                    "----------------------\n" +
                    "(3)Listar Productos Disponibles\n" +
                    "(4)Listar Productos NO Disponibles\n" +
                    "(5)Listar Articulos Antiguos por fecha\n" +
                    "(6)listar Clientes\n" +
                    "----------------------\n" +
                    "(7)ModificarProducto\n" +
                    "(8)Movimientos\n" +
                    "----------------------\n" +
                    "(9)Salir");
                resp = Console.ReadLine();

                switch (resp)
                {
                    case "1":
                        LinqTrueques.AgregarCliente();
                        break;
                    case "2":
                        LinqTrueques.AgregarProducto();
                        break;
                    case "3":
                        LinqTrueques.ProductosDisponibles();
                        break;
                    case "4":
                        LinqTrueques.ProductosNoDisponibles();
                        break;
                    case "5":
                        LinqTrueques.BuscarProductoPorFecha();
                        break;
                    case "6":
                        LinqTrueques.ListarClientes();
                        break;
                    case "7":
                        LinqTrueques.ModificarDisponible();
                        break;
                    case "8":
                        LinqTrueques.ListarOperaciones();
                        break;

                }
            } while (resp != "9");
            Console.Write("Que tenga buen día");
        }
    }
}
