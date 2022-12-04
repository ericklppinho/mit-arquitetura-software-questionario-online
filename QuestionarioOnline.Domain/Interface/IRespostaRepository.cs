using System;
using QuestionarioOnline.Domain.Entities;

namespace QuestionarioOnline.Domain.Interface
{

	public interface IRespostaRepository
	{

        Task<IEnumerable<Resposta>> GetTotalAsync(Guid questionarioId);

        Task<IEnumerable<Resposta>> GetAllAsync(Guid perguntaId);

        Task<IEnumerable<Resposta>> GetAsync(Guid id);

        Task AddAsync(Resposta resposta);

        Task UpdateAsync(Resposta resposta);

        Task DeleteAsync(Guid id);

    }

}

