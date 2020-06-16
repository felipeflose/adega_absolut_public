using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppWeb.Models
{
    public class HomeViewModel
    {
        //Métodos get e métodos sets. 
        public int ano { get; set; }

        //prop tab 
        public int Produtos { get; set; }

        public int quantidade { get; set; }
        

    }
}