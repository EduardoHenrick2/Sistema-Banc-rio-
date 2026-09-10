using System.Collections.Generic;
using SistemaBancario.Enums;

namespace SistemaBancario.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string NumeroConta { get; set; } = string.Empty;
        public string Agencia { get; set; } = string.Empty;
        public decimal Saldo { get; set; }
        public TipoConta Tipo { get; set; }
        
        public int UsuarioId { get; set; }
        public Usuario? Usuario { get; set; }

        public ICollection<Transacao> Transacoes { get; set; } = new List<Transacao>();
    }
}
