using System;
using LojaEletronicos.Repositorio;

namespace LojaEletronicos
{
    public class ProgramCliente
    {
        public void programCliente(){
            InserirCliente();
            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
					    InserirCliente();
						break;
					case "2":
						AtualizarCliente();
						break;
					case "3":
						ExcluirCliente();
						break;
					case "4":
						VisualizarCliente();
						break;
					case "C":
						Console.Clear();
						break;

					default:
						throw new ArgumentOutOfRangeException();
				}

				opcaoUsuario = ObterOpcaoUsuario();
			}

        }

        void InserirCliente(){
        Pessoa p = new Pessoa();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        p.setNome(nome);

        Console.Write("Digite seu CPF: ");
        string cpf = Console.ReadLine();
        p.setCpf(cpf);

        
        int id = RepositorioCliente.getInstancia().ProximoId();
        Console.WriteLine("ID: "+id);
        RepositorioCliente.getInstancia().Insere(p);
	
    }

   void AtualizarCliente(){

        Console.Write("Digite o id: ");
		int id = int.Parse(Console.ReadLine());

        
        Pessoa p = new Pessoa();

        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine();
        p.setNome(nome);

        Console.Write("Digite seu CPF: ");
        string cpf = Console.ReadLine();
        p.setCpf(cpf);
        Console.WriteLine("ID: "+id);
        RepositorioCliente.getInstancia().Insere(p);

        p.setCodigo(id);

        RepositorioCliente.getInstancia().Insere(p);

    }

    void ExcluirCliente(){
        Console.Write("Digite o id do produto: ");
		int id = int.Parse(Console.ReadLine());

        RepositorioCliente.getInstancia().Exclui(id);
    }

    void VisualizarCliente(){
        Console.Write("Digite o id do produto: ");
        int id = int.Parse(Console.ReadLine());

        var pessoa = RepositorioCliente.getInstancia().RetornaPorId(id);

        Console.WriteLine(pessoa);
    
    }
    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1- Inserir Cliente");
        Console.WriteLine("2- Atualizar Cliente");
        Console.WriteLine("3- Excluir Cliente");
        Console.WriteLine("4- Visualizar Cliente");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
    }
}
    