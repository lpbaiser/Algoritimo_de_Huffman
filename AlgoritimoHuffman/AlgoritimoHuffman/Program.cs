using System;
using System.Collections.Generic;

namespace AlgoritimoHuffman
{
    class MainClass
    {
        public static void Main(string[] args)
        {


            ManipulaArquivo mp = new ManipulaArquivo();
            Dictionary<char, int> caracteres = mp.LerArquivo("/Dados/Documents/NetBeansProjects/Algoritmo_de_Huffman/Algoritimo_de_Huffman/test.txt");
            String frase = mp.Texto;
            Console.WriteLine("### characters! ###");
            foreach (var item in caracteres)
            {
                if (item.Value.Equals(' '))
                {
                    Console.Write("espaço");
                }
                //Console.WriteLine ("caracter", item, "freq: ", caracteres[item])/;
                Console.WriteLine("caracter = {0}, freq = {1}", item.Key, item.Value);
			
            }

            caracteres = mp.SortDictionary(caracteres);
            Console.WriteLine("\n### sorted characters! ###\n");
  
            Arvore tree = new Arvore();

            Node root = tree.BuildTree(caracteres);
            tree.InOrder(root);

            Dictionary<char, String> hash = tree.HashCaminhos;
            tree.CriaTabela(root, "");
  
            Data data = new Data(tree, frase);
            Serializa s = new Serializa();
            s.Serializar(data);


            Data newdata = s.Desserializar();

            String newFrase = newdata.Descompacta();
            Serializa s1 = new Serializa("/Dados/Documents/NetBeansProjects/Algoritmo_de_Huffman/Algoritimo_de_Huffman/Arquivo_Descomp.txt");
            s1.SerializarString(newFrase);

        }
    }
}
