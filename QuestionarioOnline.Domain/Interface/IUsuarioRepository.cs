using System;
using QuestionarioOnline.Domain.Entities;

namespace QuestionarioOnline.Domain.Interface
{

	public interface IUsuarioRepository
	{

        Task<IEnumerable<Usuario>> GetAllAsync();

        Task<IEnumerable<Usuario>> GetAsync(Guid id);

        Task<IEnumerable<Usuario>> GetAsync(string email, string password);

        Task AddAsync(Usuario usuario);

        Task UpdateAsync(Usuario usuario);

        Task DeleteAsync(Guid id);

    }

}

