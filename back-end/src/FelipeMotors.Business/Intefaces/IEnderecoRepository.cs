using System;
using System.Threading.Tasks;
using FelipeMotors.Business.Models;

namespace FelipeMotors.Business.Intefaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);
    }
}