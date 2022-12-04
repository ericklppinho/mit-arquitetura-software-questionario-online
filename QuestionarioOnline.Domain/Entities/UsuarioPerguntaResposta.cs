using System;

namespace QuestionarioOnline.Domain.Entities
{

	public class UsuarioPerguntaResposta
    {

        private UsuarioPerguntaResposta() { }

        public UsuarioPerguntaResposta(Guid usuarioId, Guid perguntaId, Guid respostaId)
        {
            UsuarioId = usuarioId;
            PerguntaId = perguntaId;
            RespostaId = respostaId;
            CreatedAt = DateTime.Now;
        }

        public Guid UsuarioId { get; private set; }
        public Guid PerguntaId { get; private set; }
        public Guid RespostaId { get; private set; }
        public DateTime CreatedAt { get; private set; }

    }

}

