using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClienteCollection;

namespace ContratoCollection
{
    public partial class Contrato
    {
        public int IdContrato { get; set; }
        public string Creacion { get; set; }
        public string Termino { get; set; }
        public DateTime FechaHoraInicio { get; set; }
        public DateTime FechaHoraTermino { get; set; }
        public string Direccion { get; set; }
        public bool EstaVigente { get; set; }
        public TipoEvento Tipo { get; set; }
        public string Observaciones { get; set; }
        public Cliente Cliente;

        public Contrato()
        {
            this.Init();
        }

        private void Init()
        {
            IdContrato = 0;
            Creacion = string.Empty;
            Termino = string.Empty;
            FechaHoraInicio = DateTime.Today;
            FechaHoraTermino = DateTime.Today;
            Direccion = string.Empty;
            EstaVigente = false;
            Observaciones = string.Empty;
            Tipo = new TipoEvento();

        }
    }
}
