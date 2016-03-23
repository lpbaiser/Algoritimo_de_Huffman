using System;
using System.Collections.Generic;
using System.Collections;

namespace AlgoritimoHuffman{
	public class Arvore{

//		private Node root;
//		private List<Node> tree;

		public Arvore (){}
		/*
		 * Este método faz a contrução da arvore binária, seus nós intermediários armazenam
		 * a soma peso dos nós filhos, os nós folhas armazenam um caracter.
		*/
		public List<Node> buildTree(Dictionary<char, int> dict){
			Arvore tree = new Arvore ();
			List<Node> nodes = createNodes (dict);

			int j = 0;
			for (int i = nodes.Capacity; i > 1; i--) {
				Node newNode = joinNodes (nodes[j], nodes[j+1]);
				nodes.RemoveAt (j);
				nodes.RemoveAt (j + 1);
				nodes.Add (newNode);
			}

//			tree.tree = nodes;
			return nodes;
		}
		//Pega o dicionário de char e int e cria uma lista de nós
		public List<Node> createNodes(Dictionary<char, int> dict){

			List<Node> nodes = new List<Node> ();
			foreach (var item in dict) {
				Node n = new Node ();
				n.Caracter = item.Key;
				n.Peso = item.Value;
				nodes.Add (n);
			}
			return nodes;
		}
		//Junta dois nós, método deve ser chamado pelo método buildTree
		public Node joinNodes(Node nodeEsq, Node nodeDir){
			//Cria um nó raiz para os dois nós
			Node newNode = new Node ();

			//calcula o peso para o nó raiz
			int newPeso = nodeEsq.Peso + nodeDir.Peso;

			//atribui o peso
			newNode.Peso = newPeso;

			//atribui os nós respectivamente esquerda e direita;
			newNode.NoEsquerda = nodeEsq;
			newNode.NoDireita = nodeDir;

			return newNode;
		}
	}
}

