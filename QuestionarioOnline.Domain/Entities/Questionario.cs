using System;
namespace QuestionarioOnline.Domain.Entities
{

	public class Questionario
	{

        private Questionario() { }

        public Questionario(string description, DateTime timeDue)
        {
            Id = Guid.NewGuid();
            Description = description;
            TimeDue = timeDue;
            CreatedAt = DateTime.Now;
        }

        private Questionario(Guid id, string description, DateTime timeDue)
        {
            Id = id;
            TimeDue = timeDue;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Description { get; private set; }
        public DateTime TimeDue { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public IEnumerable<Pergunta> Perguntas { get; set; }

    }

}

