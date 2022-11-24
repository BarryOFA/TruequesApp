
namespace TruequesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            LinqTrueques listaApp = new LinqTrueques();

            listaApp.AgregarProductos(1,"zapato",10.000f,"cartera","02-11-2022",true);

            listaApp.MostrarProductos();
        }
    }
}