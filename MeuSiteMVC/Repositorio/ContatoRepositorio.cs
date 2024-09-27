using MeuSiteMVC.Data;
using MeuSiteMVC.Models;

namespace MeuSiteMVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
                

    }
    public ContatoModel Adicionar(ContatoModel contato)
        {
            // gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;

        }
    }
}
