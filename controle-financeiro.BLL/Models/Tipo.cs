using System.Collections.Generic;

namespace controle_financeiro.BLL.Models
{
    public class Tipo
    {
        public int TipoId { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Categoria> Categoria { get; set; }
    }
}
