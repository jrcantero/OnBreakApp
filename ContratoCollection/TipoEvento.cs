using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContratoCollection
{
    public class TipoEvento
    {
        public int IdTipo { get; set; }
        public string NombreEvento { get; set; }
        public int ValorBase { get; set; }
        public int PersonalBase { get; set; }

        public TipoEvento()
        {
            this.Init();
        }

        private void Init()
        {
            IdTipo = 0;
            NombreEvento = string.Empty;
            ValorBase = 0;
            PersonalBase = 0;
        }


    }
}
