// See https://aka.ms/new-console-template for more information
using System;

namespace ConsoleApp1
{
    class LendoArquivo
    {
        public static void Main(string[] args)
        {
            string[] linhas = System.IO.File.ReadAllLines(@"C:\Users\joao.mende\Primeiraavaliacao\teste.txt");

            // exibindo o conteudo do arquivo
            System.Console.WriteLine("Conteúdo do arquivo txt ");
            foreach (string linha in linhas)
            {
                
                System.Console.WriteLine("\t" + linha);
            }

            Console.WriteLine("Inserindo os valores dentro de um array");
            string[] array = new string[linhas.Length];
            int i = 0;
            foreach (string linha in linhas)
            {
                array[i] = linha;
                i++;
            }
            Console.WriteLine("Valores do array");
            foreach (string linha in array)
            {
                Console.WriteLine("\t" + linha);
            }
            Console.WriteLine("Ordenando os valor do array com Insertion Sort");
            //realizando a ordenação do array com Insertion Sort
            for (int j = 1; j < array.Length; j++)
            {
                string key = array[j];// chave para comparação
                int k = j - 1;//variável para comparação
                while (k >= 0 && array[k].CompareTo(key) > 0)//comparando os valores do array
                {
                    array[k + 1] = array[k];//realizando a troca dos valores
                    k--;//decrementando a variável
                }
                {
                    array[k + 1] = array[k];//realizando a troca dos valores
                    k--;//decrementando a variável
                }
                array[k + 1] = key;
            }
            Console.WriteLine("Valores do array ordenado");
            foreach (string linha in array)
             {
                Console.WriteLine("\t" + linha);
            }
            Console.WriteLine("Inserindo os valores ordenados em uma coleção");
            //criando uma coleção para armazenar os valores ordenados
            System.Collections.Generic.List<string> lista = new System.Collections.Generic.List<string>();
            foreach (string linha in array)
            {
                lista.Add(linha);//adicionando os valores do array na coleção
            }
            Console.WriteLine("Valores do array ordenado");
            foreach (string linha in lista)
            {
                Console.WriteLine("\t" + linha);
            }

            Console.WriteLine("Valores da coleção");
            foreach (string linha in lista)
            {
                Console.WriteLine("\t" + linha);
            }
            //comparando os valores da coleção com os valores do array
            Console.WriteLine("Comparando os valores da coleção com os valores do array");
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j].Equals(lista[j]))//comparando os valores da coleção com os valores do array
                {
                    Console.WriteLine("Os valores são iguais");
                }
                else
                {
                    Console.WriteLine("Os valores são diferentes");
                    break;
                }
            }
            Console.WriteLine("Valores comparados");

            Console.WriteLine("Inserindo os valores da coleção em um arquixo txt");
            //inserindo os valores da coleção em um arquivo txt
            System.IO.File.WriteAllLines(@"C:\Users\joao.mende\Primeiraavaliacao\teste2.txt", lista);//inserindo os valores da coleção em um arquivo txt
            Console.WriteLine("Valores do arquivo txt");
            foreach (string linha in lista)
            {
                Console.WriteLine("\t" + linha);
            }
        
            


    }




}
}


