using website_asp_net_and_dapperorm;
namespace website_asp_net_and_dapperorm
{
    public class Manga
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public int Capituloslidos { get; set; }

        public Manga()
        {
            this.Id = 0;
            this.Nome = "";
            this.Autor = "";
            this.Genero = "";
            this.Capituloslidos = 0;
        }
        public Manga(int id, string nome, string autor, string genero, int capitulosLidos)
        {
            this.Id = id;
            this.Nome = nome;
            this.Autor = autor;
            this.Genero = genero;
            this.Capituloslidos = capitulosLidos;
        }
    }
}
