using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppWeb.Models
{
    public class EstoqueViewModel
    {
        //Métodos get e métodos sets. 
        public int IdEstoque { get; set; }

        //prop tab 
        public int IdProduto { get; set; }

        public int quantidade { get; set; }
        
         public DateTime data_movimentacao { get; set; }

         public float valor_unitario { get; set; }

          public float ValorTotal { get; set; }

         public string tipo_movimentacao { get; set; }

          public string nome_produto { get; set; }

        public List<SelectListItem> listaprodutos { get; set; }
         public int produtoSelecionado { get; set; }

    }
}