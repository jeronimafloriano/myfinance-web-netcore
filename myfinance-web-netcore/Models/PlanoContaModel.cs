using System.ComponentModel.DataAnnotations;
using Microsoft.Net.Http.Headers;

namespace myfinance_web_netcore.Models{

    public class PlanoContaModel{

        public int Id {get;set;}

        [Required(ErrorMessage ="É necessário informar a descricao do item de Plano de Conta.")]
        public string Descricao{get;set;}

        [Required(ErrorMessage ="É necessário informar o tipo do item de Plano de Conta.")]
        public string Tipo {get;set;}
    }
}