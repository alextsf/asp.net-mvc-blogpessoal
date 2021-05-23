using System;
using System.Linq;
using BlogPessoal.Web.Data.Contexto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlogPessoal.Tests
{
    [TestClass]
    public class CategoriadeArtigoTest
    {
        //É necessário adicionar o EF nesse projeto de teste

       //Teste para verificar se está ok as configurações da entidade: string de conexao, mapeamento etc

        [TestMethod]
        public void Consultar_Artigo_Com_Sucesso()
        {
            //instanciando o contexto
            var ctx = new BlogPessoalContexto();

            var obj = ctx.CategoriasdeArtigo.FirstOrDefault();


            //validando o objeto acima
            Assert.IsNotNull(obj);
        }
    }
}
