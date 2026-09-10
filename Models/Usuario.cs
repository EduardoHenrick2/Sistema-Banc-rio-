using System.Collections.Generic;

namespace SistemaBancario.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        
        // Propriedade de navegação
        public ICollection<Conta> Contas { get; set; } = new List<Conta>();
    }
}
