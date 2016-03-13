using System;
using System.Collections.Generic;

namespace AlgoritimoHuffman{

	public class Arvore{

		private Node root;

		public Arvore (){}

		/*
		 * Este método faz a contrução da arvore binária, seus nós intermediários armazenam
		 * a soma peso dos nós filhos, os nós folhas armazenam um caracter.
		*/
		public Arvore buildTree(Dictionary<char, int> dict){
			return null;
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

