namespace controle_financeiro.BLL.Models
{
    public class Ganho
    {
        public int GanhoId { get; set; } 

        public string Nome { get; set; }    

        public int CategoriaId { get; set; }    

        public Categoria Categoria { get; set; }    

        public double Valor { get; set; }   
        
        public int Dia { get; set; }

        public int MesId { get; set; }

        public Mes Mes { get; set; }

        public int Ano { get; set; }

        public string UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
    }
}
