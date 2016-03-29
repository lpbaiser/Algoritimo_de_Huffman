using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace AlgoritimoHuffman{
	public class ManipulaArquivo{

		public ManipulaArquivo ()
		{

		}
		/*
		Método que faz a leitura de um arquivo texto, adiciona cada caracter em um Dictionary,
		calculando sua frequencia e retorna um Dictionary na ordem de leitura
		*/
		public Dictionary<char,int> lerArquivo(String path){

			Dictionary<char, int> caracteres = new Dictionary<char, int> ();
//	???		Dictionary<Object, int> caracteres = new Dictionary<Object, int> ();

			using (var arquivo = new FileStream(path, FileMode.Open, FileAccess.Read)) {
				while (arquivo.CanRead && arquivo.Position < arquivo.Length) {
					char caracter = (char)arquivo.ReadByte ();

					if (!caracteres.ContainsKey (caracter)) {
						caracteres.Add (caracter, 1);
					} else {
						caracteres [caracter] += 1;
					}
				}
			}
			return caracteres;
		}

		/*
		Ordena o dicionario pelo valor
		O Dictionary não consegue armazenar seus dados ordenados, embora o SortedDictionary
		pode ser utilizado para ordenar dados pela key(não aplica ao nosso caso),
		neste método foi implementado uma lógica que faz a cópia dos dados para uma estrutura
		que comporta os dados dentro de uma lista, assim podemos ordenar os dados pelo valor do dicionário.
		*/
		public Dictionary<char,int>sortDictionary(Dictionary<char, int> dict){

			//Cria um novo dictionary para a cópia dos dados 
			Dictionary<char, int> sortedCharacters = new Dictionary<char, int> ();

			//Adiciona cada par de valores do dictionary no List e ordena pelo valor
			List<KeyValuePair<char, int>> sorted = (from kv in dict orderby kv.Value select kv).ToList();

			//Faz a cópia de KeyValuePair para um Dictionary
			foreach (KeyValuePair<char,int> kv in sorted) {
				sortedCharacters.Add (kv.Key, kv.Value);
			}

			return sortedCharacters;
		}
	}
}

