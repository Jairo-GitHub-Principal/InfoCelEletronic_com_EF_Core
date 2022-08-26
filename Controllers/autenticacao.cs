using System.Reflection;
using System.Threading;

using System.Security.Cryptography;

using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Reflection.Metadata;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using InfoCelEletronic.Models;


namespace InfoCelEletronic.Controllers
{
    public  class Autenticacao
    {
        public static void CheckLogin(Controller controller)
        {   
            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))
            {
                controller.Request.HttpContext.Response.Redirect("/cliente/LoginCliente");
            }
        }

        //verificar login e senha

        public static bool verificaLoginSenha(string login, string senha, Controller controller){

            using (infoceleletronicContext bc = new infoceleletronicContext())
            { 
                // senha 
                verificarSeAdminExiste(bc);
              
                //string s = Cryptographya.TextoCryptographado(senha); 

                IQueryable<cliente> UsuarioEncontrado = bc.clientedb.Where(u => u.nomeUsuario==login && u.senha==senha);
                List<cliente> listaUsuarioEncontrado = UsuarioEncontrado.ToList();

                if(listaUsuarioEncontrado.Count == 0){
                    return false;

                }else{ //variaveis de sessão
                    controller.HttpContext.Session.SetString("login",listaUsuarioEncontrado[0].nomeUsuario);
                    controller.HttpContext.Session.SetString("nome",listaUsuarioEncontrado[0].nome);
                    controller.HttpContext.Session.SetInt32("tipo",listaUsuarioEncontrado[0].Tipo);
                    controller.HttpContext.Session.SetInt32("IdCliente",listaUsuarioEncontrado[0].id);
                    return true;
                }

                 
            }
        }

        public static void verificarSeAdminExiste(infoceleletronicContext bc){
             IQueryable<cliente> UsuarioEncontrado = bc.clientedb.Where(u => u.nomeUsuario == "admin");
                if(UsuarioEncontrado.ToList().Count == 0){
                    // criar o usuario admin
                    cliente admin = new cliente();
                    admin.nome ="Administrador";
                    admin.nomeUsuario="admin"; 
                    admin.senha = "123";
                    //admin.senha=Cryptographya.TextoCryptographado("123");
                    admin.Tipo = cliente.usuarioADMIN;

                    bc.clientedb.Add(admin);
                    bc.SaveChanges();
                }
        }

        

        // verificar se o usuario é admin 
        public static void verificaSeUsuarioAdmin(Controller controller){
            if(!( controller.HttpContext.Session.GetInt32("tipo")==cliente.usuarioADMIN)){
                controller.Request.HttpContext.Response.Redirect("/Home/NeedAdmin");
            }
        }
    }
}
        
    
