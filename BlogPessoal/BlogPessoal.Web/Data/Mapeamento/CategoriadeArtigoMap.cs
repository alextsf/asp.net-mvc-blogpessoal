using BlogPessoal.Web.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogPessoal.Web.Data.Mapeamento
{
    public class CategoriadeArtigoMap : EntityTypeConfiguration<CategoriadeArtigo>
    {
        //Exemplo de Validação por FluntApi ao invés de DataAnnotations

        public CategoriadeArtigoMap()
        {   
            //definindo a tabela
            ToTable("categoria_artigo", "dbo");

            //definindo a PK
            HasKey(t => t.Id);

            //definindo o restante dos campos
            Property(x => x.Nome).IsRequired().HasMaxLength(150).HasColumnName("nome");
            Property(x => x.Descricao).IsOptional().HasMaxLength(300).HasColumnName("descricao");
        }
    }
}