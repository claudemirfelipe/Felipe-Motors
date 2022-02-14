using System;
using System.Threading.Tasks;
using FelipeMotors.Business.Intefaces;
using FelipeMotors.Business.Models;
using FelipeMotors.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace FelipeMotors.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}