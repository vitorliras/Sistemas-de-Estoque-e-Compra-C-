using System;
using LojaEletronicos;

namespace LojaEletronicos
{
    public class Loja : EntidadeBase
    {
       

        private double preco;
        private Produtos produto{get; set;}
        private string tipo{get; set;}
        private int quantidade;
        private bool Excluido {get; set;}
        public int id { get; private set; }

        public override string ToString(){
            string retorno = "";
            retorno += "Produto -"+ this.produto + Environment.NewLine;
            retorno += "Quantidade -" + this.quantidade + Environment.NewLine;
            retorno += "Preço -"+ this.preco + System.Environment.NewLine;
            retorno += "Tipo -"+ this.tipo + System.Environment.NewLine;
            return retorno;
        }

        
         public bool getExcluido()
		{
			return this.Excluido;
		}

        public int getId(){
            return this.Id; 
        }

        public int getQtd(){
            return this.quantidade; 
        }

        public void setQtd(int quantidade){
            this.quantidade = quantidade; 
        }
        public Produtos getProduto(){
            return this.produto; 
        }

        public void setProduto(Produtos produto){
            this.produto = produto; 
        }
        public void setId(int id){
            this.id = id; 
        }

        public double getPreco(){
            return this.preco; 
        }
        

        public void setPreco(double preco){
            this.preco = preco; 
        }
        public void setTipo(string tipo){
            this.tipo = tipo; 
        }

        public string getTipo(){
            return this.tipo; 
        }

        public void Exclui(){
            this.Excluido = true;
        }

    }
}