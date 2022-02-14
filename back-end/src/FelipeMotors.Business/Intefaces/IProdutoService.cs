using System;
using System.Threading.Tasks;
using FelipeMotors.Business.Models;

namespace FelipeMotors.Business.Intefaces
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}