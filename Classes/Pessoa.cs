using System;

namespace LojaEletronicos
{
    public class Pessoa
    {
        private string nome;
        private string cpf;
        private int codigo;
        private bool Excluido {get; set;}
        
        public override string ToString(){
            string retorno = "";
            retorno += "Nome -"+ this.nome + Environment.NewLine;
            retorno += "cpf -" + this.cpf + Environment.NewLine;
            retorno += "Código do Cliente -"+ this.codigo + System.Environment.NewLine;
            return retorno;
        }

        public bool getExcluido()
		{
			return this.Excluido;
		}

        public int getCodigo(){
            return this.codigo; 
        }
        public void setCodigo(int codigo){
            this.codigo = codigo; 
        }
        public string getCpf(){
            return this.cpf; 
        }
        public void setCpf(string cpf){
            this.cpf = cpf; 
        }
        public string getNome(){
            return this.nome; 
        }
        public void setNome(string nome){
            this.nome = nome; 
        }
        public void Exclui(){
            this.Excluido = true;
        }
    }
}