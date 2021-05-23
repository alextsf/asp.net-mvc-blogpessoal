using BlogPessoal.Web.Data.Mapeamento;
using BlogPessoal.Web.Models;
using System.Data.Entity;

namespace BlogPessoal.Web.Data.Contexto
{
    public class BlogPessoalContexto : DbContext
    {
        //A string de conexão configurada no web.config é passada aqui para o contexto ...
        //para ele inicializar a string de conexão e carregar o banco de dados
        public BlogPessoalContexto()
            : base(typeof(BlogPessoalContexto).Name)
        {

        }

        public DbSet<CategoriadeArtigo> CategoriasdeArtigo { get; set; }

        //Responsável pelo Mapeamento
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Adicionado classe de Mapeamento
            modelBuilder.Configurations.Add(new CategoriadeArtigoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}