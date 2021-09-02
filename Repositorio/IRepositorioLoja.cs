using System.Collections.Generic;

namespace LojaEletronicos.Repositorio
{
    public interface IRepositorioLoja<Loja>
    {
         List<Loja> Lista();
         Loja RetornaPorId(int id);
         void Insere(Loja entidade);
         void Exclui(int id);
         void Atualizar(int id, Loja entidade);
         int ProximoId();
         void ReitrarProdutoQTD(int id, int qtd);
         void AcrestentarProdutoQTD(int id, int qtd);
    }
}