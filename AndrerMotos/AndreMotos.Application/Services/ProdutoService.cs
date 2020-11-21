using AndreMotos.Application.Interface;
using AndreMotos.Application.Services.Base;
using AndreMotos.Application.Validacao;
using AndreMotos.Data.Interfaces;
using AndreMotos.Dominio.EstoqueRoot;
using System;


namespace AndreMotos.Application.Services
{
   public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepositorio _repository;
        public ProdutoService(INotificador notificador,
                            IProdutoRepositorio repository) : base(notificador)
        {
            _repository = repository;
        }

        public bool Adicionar(Produto model)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), model))
                return false;

            try
            {
                _repository.Adicionar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível adicionar o registro. Motivo: {0}", ex.Message);
                return false;
            }
        }

        public bool Atualizar(Produto model)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), model))
                return false;

            try
            {
                _repository.Atualizar(model);
                return true;
            }
            catch (Exception ex)
            {
                Notificar("Não foi possível atualizar o registro. Motivo: {0}", ex.Message);
                return false;
            }
        }
    }
}

