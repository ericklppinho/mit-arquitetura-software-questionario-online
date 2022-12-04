using System;

namespace QuestionarioOnline.Domain.Entities
{

	public class Resposta
	{

		private Resposta() { }

        public Resposta(Guid perguntaId, string description)
        {
            Id = Guid.NewGuid();
            PerguntaId = perguntaId;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        private Resposta(Guid id, Guid perguntaId, string description)
        {
            Id = id;
            PerguntaId = perguntaId;
            Description = description;
        }

        private Resposta(Guid id, Guid perguntaId, string description, int total)
        {
            Id = id;
            PerguntaId = perguntaId;
            Description = description;
            Total = total;
        }

        public Guid Id { get; private set; }
        public Guid PerguntaId { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public int Total { get; private set; }

    }

}

