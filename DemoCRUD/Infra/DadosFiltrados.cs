using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoCRUD.Infra
{
    public class DadosFiltrados
    {
        public int Pagina { get; set; }
        public int Registros { get; set; }
        public int Total { get; set; }
        public int TotalFiltrado { get; set; }
        public dynamic Dados { get; set; }
    }
}