using System.Collections;
using System.Collections.Generic;

using System;
namespace InfoCelEletronic.Models
{
    public class servicos
    {
        public int id {get;set;}
       public string categoriaserv {get; set;}
       public string nomedoservico   {get; set;} 
       public int quantidadeserv {get;set;}

        public double valorunitario {get;set;}
         public double valortotal {get;set;}
         public string clienteNome{get; set;}
         public int clienteId{get; set;}
    
         public cliente cliente{get; set;}



    
      
       
        
       
    }
}