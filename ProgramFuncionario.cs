using System;
using LojaEletronicos.Repositorio;

namespace LojaEletronicos
{
    public class ProgramFuncionario
    {
        public void programFuncionario(){

            string opcaoUsuario = ObterOpcaoUsuario();

			while (opcaoUsuario.ToUpper() != "X")
			{
				switch (opcaoUsuario)
				{
					case "1":
					    InserirProduto();
						break;
					case "2":
						ListarProduto();
						break;
					case "3":
						AtualizarProduto();
						break;
					case "4":
						ExcluirProduto();
						break;
					case "5":
						VisualizarProduto();
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

    void InserirProduto(){
        Console.WriteLine("Insira o produto: ");
        foreach (int i in Enum.GetValues(typeof(Produtos)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Produtos), i));
			}
        Loja l = new Loja();
        Console.Write("Digite o produto entre as opções acima: ");
        int produto = int.Parse(Console.ReadLine());
        l.setProduto((Produtos)produto);

        Console.Write("Digite a Tipo do produto: ");
        string tipo = Console.ReadLine();
        l.setTipo(tipo);

        Console.Write("Digite a quantidade do produto: ");
        int quantidade = int.Parse(Console.ReadLine());
        l.setQtd(quantidade);

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        l.setPreco(preco);

       /* Random random = new Random();
        int id = random.Next(10000);
        l.setId(id);*/
        int id = RepositorioLoja.getInstancia().ProximoId();
        Console.WriteLine(id);
        l.setId(id);

        Repositorio.RepositorioLoja.getInstancia().Insere(l);
	
    }

    void ListarProduto(){
        Console.WriteLine("Listar Produtos");

			var lista = RepositorioLoja.getInstancia().Lista();

			if (lista.Count == 0)
			{
				Console.WriteLine("Nenhum Produto encontrado.");
				return;
			}

			foreach (var produto in lista)
			{
                var excluido = produto.getExcluido();

                Console.WriteLine("#ID {0} - {1} {2}",produto.getId(), produto.getTipo(), (excluido ? "*Excluído*" : ""));
			}
    }

   void AtualizarProduto(){

        Console.Write("Digite o id do produto: ");
		int id = int.Parse(Console.ReadLine());

        foreach (int i in Enum.GetValues(typeof(Produtos)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Produtos), i));
			}
        Loja l = new Loja();
        Console.Write("Digite o produto entre as opções acima: ");
        int produto = int.Parse(Console.ReadLine());
        l.setProduto((Produtos)produto);

        Console.Write("Digite a Tipo do produto: ");
        string tipo = Console.ReadLine();
        l.setTipo(tipo);

        Console.Write("Digite a quantidade do produto: ");
        int quantidade = int.Parse(Console.ReadLine());
        l.setQtd(quantidade);

        Console.Write("Digite o preço do produto: ");
        double preco = double.Parse(Console.ReadLine());
        l.setPreco(preco);

        l.setId(id);

        Repositorio.RepositorioLoja.getInstancia().Insere(l);

    }

    void ExcluirProduto(){
        Console.Write("Digite o id do produto: ");
		int id = int.Parse(Console.ReadLine());

        RepositorioLoja.getInstancia().Exclui(id);
    }

    void VisualizarProduto(){
        Console.Write("Digite o id do produto: ");
        int id = int.Parse(Console.ReadLine());

        var loja = RepositorioLoja.getInstancia().RetornaPorId(id);

        Console.WriteLine(loja);
    
    }



    private static string ObterOpcaoUsuario()
    {
        Console.WriteLine();
        
        Console.WriteLine("Informe a opção desejada:");

        Console.WriteLine("1- Inserir produtos");
        Console.WriteLine("2- Listar produtos");
        Console.WriteLine("3- Atualizar produtos");
        Console.WriteLine("4- Excluir produtos");
        Console.WriteLine("5- Visualizar produtos");
        Console.WriteLine("C- Limpar Tela");
        Console.WriteLine("X- Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine().ToUpper();
        Console.WriteLine();
        return opcaoUsuario;
    }
    }
}