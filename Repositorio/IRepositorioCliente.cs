

using System.Collections.Generic;

public interface IRepositorioCliente<Pessoa>
    {
         List<Pessoa> Lista();
         Pessoa RetornaPorId(int id);
         void Insere(Pessoa entidade);
         void Exclui(int id);
         void Atualizar(int id, Pessoa entidade);
         int ProximoId();
        
    }
