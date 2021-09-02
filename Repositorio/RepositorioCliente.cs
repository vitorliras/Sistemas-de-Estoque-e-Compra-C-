using System.Collections.Generic;


namespace LojaEletronicos.Repositorio
{
    public class RepositorioCliente : IRepositorioCliente<Pessoa>
    {
        private List<Pessoa> ListaClientes = new List<Pessoa>();
        private static RepositorioCliente instancia;
        public static RepositorioCliente getInstancia(){
            if(instancia == null){
                instancia = new RepositorioCliente();
            }
            return instancia;
        }

        public void Atualizar(int id, Pessoa entidade)
        {
            ListaClientes[id] = entidade;
        }

        public void Exclui(int id)
        {
            ListaClientes[id].Exclui();
        }

        public void Insere(Pessoa entidade)
        {
            ListaClientes.Add(entidade);
        }

        public List<Pessoa> Lista()
        {
            return ListaClientes;
        }

        public int ProximoId()
        {
            return ListaClientes.Count;
        }

        public Pessoa RetornaPorId(int id)
        {
            return ListaClientes[id];
        }
    }
}