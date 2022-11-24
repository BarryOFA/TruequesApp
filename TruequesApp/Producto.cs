using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TruequesApp
{
    internal class Producto
    {
        #region Propiedades
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Valor { get; set;}
        public string Preferencia { get; set; }
        public string FechCrea { get; set; }
        public bool Estado { get; set; }

        #endregion

        #region Metodos

        #endregion

        #region Constructores
        public Producto(int id, string descripcion, float valor, string preferencia, string fechCrea, bool estado)
        {
            Id = id;
            this.Descripcion = descripcion;
            this.Valor = valor;
            this.Preferencia = preferencia;
            this.FechCrea = fechCrea;
            this.Estado = estado;
        }


        #endregion
    }
}
