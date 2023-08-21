using System;

namespace MeuDesafio.Models
{
    public class Transferencia
    {
        public int Id { get; set; }
        public int SenderId { get; set; } // Id do usuário remetente
        public int receiverId { get; set; } // Id do usuário destinatário
        public decimal Valor { get; set; }
        public DateTime DataTransferencia { get; set; }
    }
}
