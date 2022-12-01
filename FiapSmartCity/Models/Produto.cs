namespace FiapSmartCity.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string Caracteristicas { get; set; }
        public double PrecoMedio { get; set; }
        public string LogoTipo { get; set; }

        public bool Ativo { get; set; }

        // referencia para a classe TipoProduto
        public TipoProduto  Tipo { get; set; }
    }
}
