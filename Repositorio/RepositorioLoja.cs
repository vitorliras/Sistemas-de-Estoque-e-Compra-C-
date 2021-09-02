using System.Collections;
using System.Collections.Generic;

namespace LojaEletronicos.Repositorio
{
    public class RepositorioLoja : IRepositorioLoja<Loja>
    {

        private List<Loja> ListaProdutos = new List<Loja>();
        private static RepositorioLoja instancia;
        public static RepositorioLoja getInstancia(){
            if(instancia == null){
                instancia = new RepositorioLoja();
            }
            return instancia;
        }

        public void AcrestentarProdutoQTD(int id, int qtd)
        {
            
        }

        public void Atualizar(int id, Loja entidade)
        {
            ListaProdutos[id] = entidade;
        }

        public void Exclui(int id)
        {
           ListaProdutos[id].Exclui();
        }

        public void Insere(Loja entidade)
        {
            ListaProdutos.Add(entidade);
        }

        public List<Loja> Lista()
        {
           return ListaProdutos;
        }

        public int ProximoId()
        {
            return ListaProdutos.Count;
        }

        public void ReitrarProdutoQTD(int id, int qtd)
        {
            
        }

        public Loja RetornaPorId(int id)
        {
            return ListaProdutos[id];
        }
    }
}