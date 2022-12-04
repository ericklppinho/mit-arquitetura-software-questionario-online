using System;
using QuestionarioOnline.Domain.Entities;

namespace QuestionarioOnline.Domain.Interface
{

	public interface IQuestionarioRepository
	{

        Task<IEnumerable<Questionario>> GetAllAsync();

        Task<IEnumerable<Questionario>> GetAllDataValidaAsync();

        Task<IEnumerable<Questionario>> GetAsync(Guid id);

        Task AddAsync(Questionario questionario);

        Task UpdateAsync(Questionario questionario);

        Task DeleteAsync(Guid id);

    }

}

