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
