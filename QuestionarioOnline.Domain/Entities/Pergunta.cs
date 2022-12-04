using System;

namespace QuestionarioOnline.Domain.Entities
{

	public class Pergunta
	{

        private Pergunta() { }

        public Pergunta(Guid questionarioId, string description)
        {
            Id = Guid.NewGuid();
            QuestionarioId = questionarioId;
            Description = description;
            CreatedAt = DateTime.Now;
        }

        private Pergunta(Guid id, Guid questionarioId, string description)
        {
            Id = id;
            QuestionarioId = questionarioId;
            Description = description;
        }

        public Guid Id { get; private set; }
        public Guid QuestionarioId { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IEnumerable<Resposta> Respostas { get; set; }

    }

}

