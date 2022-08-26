using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfoCelEletronic.Models
{
    public class servicosServicos
    {
        

        public void cadastrarServico(servicos s){
            using(infoceleletronicContext Ic = new infoceleletronicContext()){
                Ic.servicosdb.Add(s);
                Ic.SaveChanges();

            }

        }

            public List<servicos> listarServicos(){
                using(infoceleletronicContext Ic = new infoceleletronicContext()){
                    
                    return Ic.servicosdb.ToList();
                }
            }

        public void atualizarServico(servicos s){
            using(infoceleletronicContext Ic = new infoceleletronicContext()){
                servicos servicosUpdate = Ic.servicosdb.Find(s.id);
                servicosUpdate.categoriaserv = s.categoriaserv;
                servicosUpdate.nomedoservico = s.nomedoservico;
                servicosUpdate.quantidadeserv = s.quantidadeserv;
                servicosUpdate.valorunitario = s.valorunitario;
                servicosUpdate.valortotal = s.valortotal;

                Ic.SaveChanges();
            }


            }

            public void deletServicos(int id){
                using(infoceleletronicContext Ic = new infoceleletronicContext()){
                    servicos servicoEncontrado = Ic.servicosdb.Find(id);
                    Ic.servicosdb.Remove(servicoEncontrado);
                    Ic.SaveChanges();
                }
            }


            public servicos obterPorId(int idServico){
                using(infoceleletronicContext Ic = new infoceleletronicContext()){
                    servicos servicosEncontrado = Ic.servicosdb.Where(s => s.id == idServico).SingleOrDefault();
                    return servicosEncontrado;
                }
            }


            /* o metodo abaixo é o mais indicado quando se quer fazer uma busca por ID de uma usuario
            se forma que o resultado traga somente dados que o usuario cadastro*/
            public List<servicos> listServicoID( int ID){ // pesquisar por ID
            using(infoceleletronicContext ic = new infoceleletronicContext()){
                  IQueryable<servicos> sc = ic.servicosdb.Where(s=>s.clienteId == ID);
                    List<servicos> s = new List<servicos>();
                    s.AddRange(sc); // add range possibilita adicionar um range de uma pesquisa de um Iqueryable com whare, em um objeto do tipo List<>
                    
               return s ;
            }
        }
            

    }
}