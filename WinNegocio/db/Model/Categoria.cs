using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Categoria
    {
        private int categoria_id;
        private string _nombre_categoria;
		
		
        public string NombreCategoria
        {
            get { return _nombre_categoria; }
            set { _nombre_categoria = value; }
        }

        public int CategoriaId
        {
            get { return categoria_id; }
            set { categoria_id = value; }
        }
    }
}
