using CrudAnuncioWebMotors.Domain.Commands;

namespace CrudAnuncioWebMotors.Domain.Services.Anuncio
{
    public interface IAnuncioService
    {
        Task<RequestResult> Obter();
        Task<RequestResult> Deletar(int id);
    }
}
