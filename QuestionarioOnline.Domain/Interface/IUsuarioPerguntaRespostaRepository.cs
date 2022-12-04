using System;
using QuestionarioOnline.Domain.Entities;

namespace QuestionarioOnline.Domain.Interface
{

	public interface IUsuarioPerguntaRespostaRepository
    {

        Task AddAsync(UsuarioPerguntaResposta usuarioPerguntaResposta);

    }

}

