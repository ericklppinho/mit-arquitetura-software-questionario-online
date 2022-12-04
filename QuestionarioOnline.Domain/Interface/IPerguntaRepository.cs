using System;
using QuestionarioOnline.Domain.Entities;

namespace QuestionarioOnline.Domain.Interface
{

	public interface IPerguntaRepository
	{

        Task<IEnumerable<Pergunta>> GetAllAsync(Guid questionarioId);

        Task<IEnumerable<Pergunta>> GetAsync(Guid id);

        Task AddAsync(Pergunta pergunta);

        Task UpdateAsync(Pergunta pergunta);

        Task DeleteAsync(Guid id);

    }

}

