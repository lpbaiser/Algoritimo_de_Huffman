# Algoritimo_de_Huffman
Implementação do algoritimo de Huffman, compactação e descompactação em C#

###Passos###
1 - Ler arquivo a ser compactado
	1.1 - Processar o arquivo, caracter por caracter para descobrir seu peso(frequência com a qual os caracteres aparecem no arquivo)
	DICA: DictionaryMap = Dictionary em C# ex: <char, int>: <a, 3>; <b, 5>...

	1.2 - Ordernar Dictionary" pelo peso (cada posição do Dictionary será um nó da árvore)

2 - Construir árvore binária
	2.1 - Juntar os dois primeiros nós, a soma dos pesos dos nós filhos será o peso do nó raiz da nova árvore

	2.2 - O novo nó deve ser inserido no Dictionary mantendo ordenado

	2.3 - Repetir o processo até restar apenas uma árvore

3 - Construir tabela de compactação

	#possível ideia
	3.1 - Visitar todos os nós folhas e guardar em um Dictionary a letra correspondente e o binário

	3.2 - Aplicar este Dictionary no texto de entrada para montar a tabela de compactação

4 - Gravar sequência binária no arquivo

	4.1 - Escrever cabeçalho do arquivo: A árvore binária deve estar no arquivo para a descompactação
		4.1.1 - Visitar a árvore em pré-ordem escrever cada nó visitado, diferenciar nós folhas de nós não folhas:
				"Uma maneira de fazer a diferenciação é escrever um único bit para cada nó, por
				exemplo 1 para nós folhas e 0 para nós não-folha. Para nós-folha, é também necessário
				escrever o caracter armazenado. Para nós não-folha é necessário apenas o bit indicando de
				que se trata de um nó não-folha."

	4.2 - Escrever sequencia binária.

	4.3 - Escrever bits de caracter final: "Uma solução possível poderia introduzir um pseudo-caracter de final de arquivo, 		  introduzido explicitamente pelo programador ao final da sequencia de bits válidos. Este caracter também
		  deve entrar na árvore/tabela de codificação para que seja corretamente descompactado pelo
		  programa descompactador. Quando um arquivo compactado é escrito, os últimos bits escritos
		  devem ser os bits que representam o pseudo-caracter."

5 - Descompactar 

	5.1 - Ler e criar árvore binária do arquivo.

	5.2 - Ler sequencialmente os bits e varrendo a árvore a procura dos caracteres, a cada novo caracter encontrado,
		  inserir em uma lista.

	5.3 - Imprimir os caracteres.	
