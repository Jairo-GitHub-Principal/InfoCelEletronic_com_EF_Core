
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using InfoCelEletronic.Models;




    namespace InfoCelEletronic.Controllers
{

    public class ServicosController:Controller
    {



        public IActionResult Servicos(){
            return View();
        }

        
         public IActionResult cadastrarOrcamento(){
                Autenticacao.CheckLogin(this);
        return View();
        }

[HttpPost]
          public IActionResult cadastrarOrcamento(servicos serv){
              servicosServicos sr = new servicosServicos();
              sr.cadastrarServico(serv);
              

        return View();
        }

         

        public IActionResult listarservicos(){
                     
                   
                      servicosServicos ss=new servicosServicos();
                      
                      int tipo = Convert.ToInt32(HttpContext.Session.GetInt32("tipo"));          
                      if(tipo == 0){
                          List<servicos> servicosEncontrados = ss.listarServicos();
                             return View(servicosEncontrados);    
                      }else{
                            int ID = Convert.ToInt32(HttpContext.Session.GetInt32("IdCliente"));
                          //List<servicos>servE = new List<servicos>();
                          

                           return View(ss.listServicoID(ID)); 
                      }
                    }  

       
            
        
        

        public IActionResult atualizaservico(int Id){
            
            servicosServicos ss= new servicosServicos();
            servicos encontrado= ss.obterPorId(Id);
            return View(encontrado);
        }

        [HttpPost]
          public IActionResult atualizaservico(servicos atualizar){
            servicosServicos ss= new servicosServicos();
            ss.atualizarServico(atualizar);
            return RedirectToAction("listarservicos");
        }
        
    public IActionResult excluirservico(int id){
        servicosServicos ss = new servicosServicos();
        ss.deletServicos(id);
        return RedirectToAction("listarservicos");

    }
    
    
    }
}