using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Application.Interface
{
    public interface IProdutoService : IBaseService
    {
        bool Adicionar(Produto model);
        bool Atualizar(Produto model);
    }
}
