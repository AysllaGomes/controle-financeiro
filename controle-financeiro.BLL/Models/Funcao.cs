using Microsoft.AspNetCore.Identity;

namespace controle_financeiro.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        public int FuncaoId { get; set; } 
    }
}
