using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace InfoCelEletronic.Models
{
    public class clienteServico
    {

        public cliente cadastro(cliente c){

            using(infoceleletronicContext Ic= new infoceleletronicContext()){
                Ic.clientedb.Add(c);
                Ic.SaveChanges();

                return Ic.clientedb.Find(c.id);
                }
        }


        public List<cliente> listarCliente(){
            using(infoceleletronicContext Ic= new infoceleletronicContext()){
                    

              return (Ic.clientedb.ToList());
            }
        }
         public cliente ListarPorID(int id)
        {   
            using(infoceleletronicContext bc = new infoceleletronicContext())
            {                   
                return bc.clientedb.Find(id);  
            }
        }


          public void editarCliente(cliente userEditar){
            using(infoceleletronicContext bc = new infoceleletronicContext()){

               //  Usuario u = Listar(editarUsuario.Id);  essa seria uma maneira de encontrar o usuario para editar
               cliente u = bc.clientedb.Find(userEditar.id);
               u.nome = userEditar.nome;
               u.nomeUsuario =userEditar.nomeUsuario;
               u.senha =userEditar.senha;
               u.Tipo = userEditar.Tipo;

               bc.SaveChanges(); 
            }

        }


        public void DeletCliente(int id){
            using(infoceleletronicContext ic = new infoceleletronicContext()){
                cliente clienteEcontrado = ic.clientedb.Find(id); // encontra o usuario para ser removido
                ic.clientedb.Remove(clienteEcontrado); // remove o usuario encontrado
                ic.SaveChanges(); // salva 
            }
        }

        public IQueryable listarClienteID( int id){
            using(infoceleletronicContext ic = new infoceleletronicContext()){
               IQueryable clienteEncontrado = ic.clientedb.Where(o => o.id == id);
               return clienteEncontrado;
            }
        }
        

        public List<cliente> listClieID( int id){ // pesquisar por ID
            using(infoceleletronicContext ic = new infoceleletronicContext()){
               cliente clienteEncontrado = ic.clientedb.Find(id);
               List<cliente> clienteID = new List<cliente>();
               clienteID.Add(clienteEncontrado); // todos os objetos listados por ID vai ser armazenado na lista Cliente ClienteID
               return clienteID;
            }
        }
    }
}