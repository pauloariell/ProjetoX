using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoX.Usuario.Domain.Entity.ControleAcessoAggregate
{
    public class ControleAcesso
    {
        public bool EmailVerificado { get; set; }
        public DateTime DataVerificacaoEmail { get; set; }
        public int QuantidadeVezesSenhaErrada { get; set; }
        public string ChaveRecuperacaoAcesso { get; set; }
        public DateTime ValidadeChaveRecuperacaoAcesso { get; set; }
    }
}
