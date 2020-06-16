using System;
using System.Collections.Generic;

namespace AppWeb.Models
{
    public class VendasViewModel
    {
        //Métodos get e métodos sets. 
         public int IdProduto { get; set; }

         public int id_Venda { get; set; }


        public int quantidade { get; set; }

        public string tipo_pagamento { get; set; }

         public int IdCliente { get; set; }

         public float valortotal { get; set; }

         public DateTime data_pedido { get; set; }

         public List<ProdutoViewModel> produtos { get; set; }

        public string nome_produto { get; set; }
        

    }
}


