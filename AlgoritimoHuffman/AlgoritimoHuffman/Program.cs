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
				//Console.WriteLine ("caracter", item, "freq: ", caracteres[item])/;
				Console.WriteLine ("caracter = {0}, freq = {1}", item.Key, item.Value);
			}

			caracteres = mp.ordenaDictionary (caracteres);
			Console.WriteLine ("### sorted characters! ###");
			foreach (var item in caracteres) {
				Console.WriteLine ("caracter = {0}, freq = {1}", item.Key, item.Value);
			}


		}
	}
}
