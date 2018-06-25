using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibNegocio.db
{
    public partial class Cliente
    {
        #region variables locales
        private int _cliente_id;
        private string _cedula_ruc;
		private string _nombre_cia;
        private string _nombre_contacto;        
		private string _dir_cliente;
        private string _fax;
        private string _email;
        private string _celular;
        private string _fijo;
        #endregion

        #region propiedades publicas
        public int ClienteId
        {
            get { return _cliente_id; }
            set { _cliente_id = value; }
        }

        public string CedulaRuc
        {
            get { return _cedula_ruc; }
            set { _cedula_ruc = value; }
        }

        public string NombreCia
        {
            get { return _nombre_cia; }
            set { _nombre_cia = value; }
        }
        
        public string NombreContacto
        {
            get { return _nombre_contacto; }
            set { _nombre_contacto = value; }
        }     
		
		public string DirCliente
        {
            get { return _dir_cliente; }
            set { _dir_cliente = value; }
        }

        public string Fax
        {
            get { return _fax; }
            set { _fax = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Celular
        {
            get { return _celular; }
            set { _celular = value; }
        }

        public string Fijo
        {
            get { return _fijo; }
            set { _fijo = value; }
        }
        #endregion

    }
}
