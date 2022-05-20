using CrudAnuncioWebMotors.Domain.Commands;
using CrudAnuncioWebMotors.Domain.Entities;

namespace CrudAnuncioWebMotors.Domain.Repositories
{
    public interface IAnuncioRepository
    {
        Task Adicionar(CriarAnuncioCommand command);
        Task<IEnumerable<tb_AnuncioWebmotors>> Obter();
        Task<tb_AnuncioWebmotors> Obter(int id);
        Task Atualizar(AlterarAnuncioCommand command);
        Task Deletar(int id);
    }
}
