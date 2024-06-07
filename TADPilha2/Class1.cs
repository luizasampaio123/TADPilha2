using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPilha2
{
    internal class TADPilha
    {
        private int codigo;
        private string descricao;
        private ArrayList lista;
        private int capacidade;


        public TADPilha(int codigo, string descricao, int capacidade)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.lista = new ArrayList();
            this.capacidade = capacidade;
        }
        public void empilhar(int chave)
        {
            if(capacidade>lista.Count)
            {
                lista.Add(chave);
            }
            else
            {
                Console.WriteLine("Erro");
            }

        }

        public void desempilhar()
        {
            if (lista.Count == 0)
            {
                Console.WriteLine("Pilha vazia");
            }

            lista.RemoveAt(lista.Count - 1); 

        }

        public void listar()
        {
            Console.WriteLine("Método listar iniciado");
            for(int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine($"chave:{lista[i]}");
            }
            Console.WriteLine("Método listar finalizado");
        }


    }
}
