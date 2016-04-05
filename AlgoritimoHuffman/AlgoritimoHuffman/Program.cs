using System;
using System.Collections.Generic;

namespace AlgoritimoHuffman
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			ManipulaArquivo mp = new ManipulaArquivo ();
			Dictionary<char, int> caracteres = mp.lerArquivo ("/Dados/Documents/NetBeansProjects/Algoritmo_de_Huffman/Algoritimo_de_Huffman/test.txt");
			String frase = mp.Texto;
			Console.WriteLine ("### characters! ###");
			foreach (var item in caracteres) {
				if (item.Value.Equals(' ')) {
					Console.Write ("espaço");
				}
				//Console.WriteLine ("caracter", item, "freq: ", caracteres[item])/;
				Console.WriteLine ("caracter = {0}, freq = {1}", item.Key, item.Value);
			
			}

			caracteres = mp.sortDictionary (caracteres);
			Console.WriteLine ("\n### sorted characters! ###");
			foreach (var item in caracteres) {
				Console.WriteLine ("caracter = {0}, freq = {1}", item.Key, item.Value);
			}


			Console.WriteLine ("\n### print List Nodes ###");
			Arvore tree = new Arvore ();
			List<Node> nodes = tree.createNodes (caracteres);
			foreach (var item in nodes) {
				Console.WriteLine ("Peso =  {0}, Char = {1}", item.Peso, item.Caracter);
			}


			Console.WriteLine ("\n### print List Nodes ###");
			Node root = tree.buildTree (caracteres);
			Console.WriteLine ("root =  {0}\n", root.Peso);
			tree.inOrder (root);

			Dictionary<char, String> hash = tree.HashCaminhos;
			tree.criaTabela(root,"");
			Console.WriteLine ("\n Tabela \n");


			Console.WriteLine ("\n Esp   -->"+hash[' ']);
			Console.WriteLine ("\n e     -->"+hash['e']);
			Console.WriteLine ("\n s     -->"+hash['s']);
			Console.WriteLine ("\n b     -->"+hash['b']);
			Console.WriteLine ("\n o     -->"+hash['o']);
			Console.WriteLine ("\n m     -->"+hash['m']);

			Data data = new Data (tree, frase);
			Serializa s = new Serializa ();
			s.Serializar (data);


			Data newdata = s.Desserializar();

			String newFrase = newdata.descompacta();
			Serializa s1 = new Serializa ("/Dados/Documents/NetBeansProjects/Algoritmo_de_Huffman/Algoritimo_de_Huffman/Arquivo_Descomp.txt");
			s1.SerializarString (newFrase);

		}
	}
}
