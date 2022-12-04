using System;
namespace QuestionarioOnline.Domain.Entities
{

	public class Usuario
	{

        private Usuario() { }

        public Usuario(string email, string password, bool admin)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
            Admin = admin;
            CreatedAt = DateTime.Now;
        }

        private Usuario(Guid id, string email, string password, bool admin)
        {
            Id = id;
            Email = email;
            Password = password;
            Admin = admin;
        }

        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool Admin { get; private set; }
        public DateTime CreatedAt { get; private set; }

    }

}

