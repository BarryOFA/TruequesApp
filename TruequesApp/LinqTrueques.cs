using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace TruequesApp
{
    internal class LinqTrueques
    {
        private List<Producto> losProductos = new List<Producto>();

        #region Metodos
        public void AgregarProductos (int id, string descripcion, float valor, string preferencia, string fechCrea, bool estado)
        {
            losProductos.Add(new Producto(id, descripcion, valor, preferencia, fechCrea, estado));
        }

        public void MostrarProductos()
        {
            Console.WriteLine(losProductos);
        }

        #endregion
    }
}
