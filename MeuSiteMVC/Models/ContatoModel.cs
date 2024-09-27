using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 



namespace MeuSiteMVC.Models
{
    public class ContatoModel
    {
        //representa o codigo do contato, sendo numerado
        public int Id { get; set; }
        public string Nome { get; set; }   
        public string Email { get; set; }
        public string Telefone { get; set; }

    }
}
