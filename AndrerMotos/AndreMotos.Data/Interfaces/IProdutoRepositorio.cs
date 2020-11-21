using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Data.Interfaces
{
    public interface IProdutoRepositorio
    {
        List<Produto> ObterTodos();
        void Adicionar(Produto model);
        void Atualizar(Produto model);
        Produto ObterPorId(int id);
    }
}
