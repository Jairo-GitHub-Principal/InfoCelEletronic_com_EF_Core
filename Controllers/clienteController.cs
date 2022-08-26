using System.Net.Http;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using InfoCelEletronic.Models;

namespace InfoCelEletronic.Controllers
{
    public class clienteController:Controller
    {
        
        public IActionResult CadastroCliente(){
         
             
            return View();
        }

        
[HttpPost]
         public IActionResult CadastroCliente( cliente c){

            clienteServico cs = new clienteServico();   
                c.Tipo = cliente.usuarioPADRAO;
                 cs.cadastro(c);
                     ViewData["msg"]= "cadastro realizado com sucesso";
                        
            return RedirectToAction("LoginCliente");
        }

         public IActionResult LoginCliente(){

                 return View();
        }

[HttpPost]
        public IActionResult LoginCliente(string login, string senha){
             if(Autenticacao.verificaLoginSenha(login,senha,this)){
                    return RedirectToAction("Index","Home");
            }else{
                 ViewData["Erro"] = "Senha, ou o nome de usuario está invalido!!";
                return View();

            }
        }
        

       


        public IActionResult ListarCliente(){
            //Autenticacao.verificaSeUsuarioAdmin(this); 
            clienteServico cs = new clienteServico();
           
           int tipo = Convert.ToInt32(HttpContext.Session.GetInt32("tipo")); 
            
            if(tipo==0){ // se o tipo for 0 o usuario é adm, e a listagem vem completa
                List<cliente> listaCliente = cs.listarCliente();
                
            return View(listaCliente);
            }else{ // se não: o tipo usuario não for 0, so pode ser 1, que significa que o usuario é padrão e não tem previlegios adm e
                   // a listagem sera feita usando o id do usuario, para listar somente o que o usuario cadastrou 
                int ID = Convert.ToInt32(HttpContext.Session.GetInt32("IdCliente"));
                  List<cliente> listaCliente = new List<cliente>();
                  listaCliente = cs.listClieID(ID);
                
                return View(listaCliente);
            }
            
         }
            
        
           public IActionResult AtualizarCliente(int id){
            cliente clienteEncontradoPorID = new clienteServico().ListarPorID(id);
            return View(clienteEncontradoPorID);
        }


        [HttpPost]
                public IActionResult AtualizarCliente(cliente clieUpdate){
                     clienteServico cs = new clienteServico();  
                    
                     cs.editarCliente(clieUpdate);
                     ViewData["msg"]= "dados atualizados com sucesso";
                     return RedirectToAction("ListarCliente");
        }


        public IActionResult excluirClirente(int id){
            clienteServico cs = new clienteServico();
            cs.DeletCliente(id);
            return RedirectToAction("ListarCliente");
        }

        
            public IActionResult logOut(){
                 HttpContext.Session.Clear();
            return RedirectToAction("Index","Home");

            }




      

    }
}

