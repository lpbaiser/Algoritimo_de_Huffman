using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace AlgoritimoHuffman{
	public class Arvore{

		private List<Node> nodes;

		public Arvore ()
		{
		}
		/*
		 * Este método faz a contrução da arvore binária, seus nós intermediários armazenam
		 * a soma peso dos nós filhos, os nós folhas armazenam um caracter.
		*/
		public Node buildTree(Dictionary<char, int> dict){
			this.nodes = createNodes (dict);

			int j = 0;
			for (int i = this.nodes.Count; i > 1; i--) {
				Node newNode = joinNodes (this.nodes [j], nodes [j + 1]);
				this.nodes.Remove (this.nodes [j]);
				this.nodes.Remove (this.nodes [j]);
				this.nodes.Add (newNode);
				this.nodes = sortNodes ();
				j = 0;
			}

//			tree.tree = nodes;
			return nodes [0];
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

			newNode.Caracter = '\0';

			//calcula o peso para o nó raiz
			int newPeso = nodeEsq.Peso + nodeDir.Peso;

			//atribui o peso
			newNode.Peso = newPeso;

			//atribui os nós respectivamente esquerda e direita;
			newNode.NoEsquerda = nodeEsq;
			newNode.NoDireita = nodeDir;

			return newNode;
		}

		public List<Node> sortNodes(){
			return this.nodes.OrderBy (o => o.Peso).ToList ();
		}

		public void inOrder(Node root){
			if (root != null) {
				inOrder (root.NoEsquerda);
				if (root.Caracter != '\0') {
					if (root.Caracter == 32) {
						Console.Write ("{space} ");
					} else {
						Console.Write ("{0} ", root.Caracter);
					}
				}
				inOrder (root.NoDireita);
			}
		}
	}
}
