using System;

namespace LojaEletronicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você é funcionário ou cliente");
            Console.WriteLine("1- Funcionario / 2 Clinte");
            int resposta = int.Parse(Console.ReadLine());
            
            if(resposta == 1){
                while( resposta == 1){
                    Console.WriteLine("Digite a senha de funcionário: ");
                    string senha = Console.ReadLine();

                    if(senha == "loja10"){
                        Console.WriteLine("Olá funcionario");
                        ProgramFuncionario pf = new ProgramFuncionario();
                        pf.programFuncionario();
                        break;
                    }else{
                        Console.WriteLine("Senha incorreta, 1- digitar senha novamente / 2- Sou Cliente / 3- cancelar e sair ");
                        int resp = int.Parse(Console.ReadLine());
                        if(resp == 1){
                            continue;
                        }else if(resp == 2){
                            resposta = 2;
                        }else{
                            break;
                        }
                    }
                }

            }if (resposta == 2){
                Console.WriteLine("Bem vindo a Loja de Eletrônicos");
                Console.WriteLine("Catlógo com os preços");
                Console.WriteLine("Notebook - R$2740,00");
                Console.WriteLine("Tv - R$4299,99");
                Console.WriteLine("Impressora - R$630,00");
                Console.WriteLine("Monitor - R$860,00");
                Console.WriteLine("Desktop - R$5200,00");
                Console.WriteLine("Headset - R$199,99");
                Console.WriteLine("Celular - R$1399,99");

                foreach (int i in Enum.GetValues(typeof(Produtos))){
				    Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Produtos), i));
			    }
                
                Console.WriteLine("Escolha o produto que desejas comprar");
                int escolha = int.Parse(Console.ReadLine());
                double total = 0.0;
                
                while(escolha > 0 && escolha <= 8){
                    Loja p = new Loja();
                    
                    if(escolha == 1){
                       // double preco = 2740.00;
                        p.setPreco(2740.00);
                        total += p.getPreco();
                        
                    }
                    if(escolha == 2){
                        p.setPreco(4299.99);
                      //  double preco = 4299.99;
                        total += p.getPreco();
                    }
                    if(escolha == 3){
                      //  double preco = 630.00;
                        p.setPreco(630.00);
                        total += p.getPreco();
                    }
                    if(escolha == 4){
                       // double preco = 860.00;
                        p.setPreco(860.00);
                        total += p.getPreco();
                    }
                    if(escolha == 5){
                       // double preco = 5200.00;
                        p.setPreco(5200.00);
                        total += p.getPreco();;
                    }
                    if(escolha == 6){
                        //double preco = 199.99;
                        p.setPreco(199.99);
                        total += p.getPreco();
                    }
                    if(escolha == 7){
                       // double preco = 1399.99;
                        p.setPreco(1399.00);
                        total += p.getPreco();
                    }
                    if(escolha == 8){
                        break;
                    }

                    foreach (int i in Enum.GetValues(typeof(Produtos))){
				        Console.Write("{0}-{1} ", i, Enum.GetName(typeof(Produtos), i));
			        }
                    Console.WriteLine();
                    Console.WriteLine("Deseja comprar mais produto 8-NÃO");
                    escolha = int.Parse(Console.ReadLine());

                }
                Console.WriteLine(" o valor total é R$"+total); 
                Console.WriteLine("Deseja pagar em crédito(1), débito(2) ou por boleto(3)");
                int pagamento = int.Parse(Console.ReadLine());
                while(pagamento != 0){
                    if(pagamento == 1){
                        Console.WriteLine("Pagamento em crédito/ dejesa dividir em quantas vezes? max 10x(taxa de 2%)");
                        int parcela = int.Parse(Console.ReadLine());
                        if(parcela > 0 && parcela <= 10){
                            double valor_parc;
                            string.Format("{0:0.00}", total += total * Constantes.Constante.taxa);
                            string.Format("{0:0.00}", valor_parc = total/ parcela);
                            Console.WriteLine("Compra de R$"+string.Format("{0:0.00}",total)+" dividida em "+parcela+" de "+string.Format("{0:0.00}",valor_parc));
                            break;
                        }
                    }
                    else if(pagamento == 2){
                        Console.WriteLine("Pagamento em Debito de R$"+total);
                        break;
                    }
                    else if(pagamento == 3){
                        Console.WriteLine("Boleto emitido de R$"+total);
                        break;
                    }
                    else{
                        Console.WriteLine("Por favor escolha o pagamento adequado");
                    }
                }

                Console.WriteLine("Deseja fazer um cadastro da loja 1-Sim / 2-Não");
                int cadastro = int.Parse(Console.ReadLine());
                if(cadastro == 1){
                    ProgramCliente pc = new ProgramCliente();
                    pc.programCliente();
                    Console.WriteLine("Obrigado pelas compras");
                }else{
                    Console.WriteLine("Obrigado pelas compras");
                }
            }
        }
    }
}
