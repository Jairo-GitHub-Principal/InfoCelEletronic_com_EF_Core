using System.Collections;

using System.Collections.Generic;
using System;



namespace InfoCelEletronic.Models
{
   
         public class cliente


    {   

        public static int usuarioADMIN = 0;
        public static int usuarioPADRAO = 1;

        public int Tipo {get; set;} // essa variavel vai ser carregada com o valor: correspondente ao tipo de usuario; se for  ADMIN= 0, se for PADRAO=1
        
        public int id {get; set;}
        public string nome{get; set;}
        public string email{get; set;}

        public string nomeUsuario{get; set;}

        public string senha{get; set;}

        public ICollection<servicos> servicos{get; set;}

         
    
        
       

      
   
       
  
        
       
        
        public cliente(){
           
        }

        
    }

}
