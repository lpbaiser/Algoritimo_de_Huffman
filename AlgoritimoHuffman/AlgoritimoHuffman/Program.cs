using System;
using System.Collections.Generic;

namespace AlgoritimoHuffman
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			ManipulaArquivo mp = new ManipulaArquivo ();
			Dictionary<char, int> caracteres = mp.lerArquivo ("/home/leonardo/Dropbox/LP/Aps1/test.txt");

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

		}
	}
}
