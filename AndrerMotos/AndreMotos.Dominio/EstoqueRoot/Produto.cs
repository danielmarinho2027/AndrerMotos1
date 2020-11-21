using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Dominio.EstoqueRoot
{
    public class Produto
    {
        public string NomeProduto { get; set; }
        public int ID { get; set; }
        public int CodigoProduto { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnitario { get; set; }
        public string Descricao { get; set; }
    }
}
