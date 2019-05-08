using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCollection
{
    public partial class Cliente
    {
        public string Rut { get; set; }
        public string Razonsocial { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }
        public string ActividadEmpresa { get; set; }
        public string TipoEmpresa { get; set; }

        public Cliente()
        {
            this.Init();
        }

        private void Init()
        {
            Rut = string.Empty;
            Razonsocial = string.Empty;
            Nombre = string.Empty;
            Email = string.Empty;
            Direccion = string.Empty;
            Telefono = 0;
            ActividadEmpresa = string.Empty;
            TipoEmpresa = string.Empty;
        }
    }

    public enum _tipoEmpresa
    {
        SPA,
        EIRL,
        Limitada,
        Sociedad_Anonima
    }

    public enum _actividadEmpresa
    {
        Agropecuaria,
        Mineria,
        Manufactura,
        Comercio,
        Hoteleria,
        Alimentos,
        Transporte,
        Servicios
    }

}
