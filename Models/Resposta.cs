using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AstroFront.Models
{
    public sealed class Resposta : BaseModel
    {
        public string Conteudo { get; set; }

        public Guid PerguntaId { get; set; }

        public bool Correta { get; set; }

        public bool Valided { get; set; } = false;
    }
}