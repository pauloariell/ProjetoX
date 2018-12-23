using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoX.Usuario.Domain.Aggregate.UsuarioAggregate
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeCompleto { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }
}
