using System;
using SistemaBancario.Enums;

namespace SistemaBancario.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataHora { get; set; }
        public TipoTransacao Tipo { get; set; }
        
        public int ContaId { get; set; }
        public Conta? Conta { get; set; }

        // Referência para conta de destino em caso de transferência
        public int? ContaDestinoId { get; set; }
        public Conta? ContaDestino { get; set; }
    }
}
