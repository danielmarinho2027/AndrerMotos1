using AndreMotos.Data.Context;
using AndreMotos.Data.Interfaces;
using AndreMotos.Dominio.EstoqueRoot;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreMotos.Data.Repositorios
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private EstoqueContext _produtos;


        public ProdutoRepositorio(EstoqueContext produtos)
        {
            _produtos = produtos;
        }

        public void Adicionar(Produto model)
        {
            _produtos.Produtos.Add(model);
            _produtos.SaveChanges();
        }

        public void Atualizar(Produto model)
        {
            _produtos.Entry(model).State = System.Data.Entity.EntityState.Modified;
            _produtos.SaveChanges();
        }

        public Produto ObterPorId(int id)
        {
            return _produtos.Produtos.Where(x => x.ID == id).AsNoTracking().FirstOrDefault();
        }

        public List<Produto> ObterTodos()
        {
            return _produtos.Produtos.AsNoTracking().ToList();
        }
    }
}
