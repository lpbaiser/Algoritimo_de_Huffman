﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace AlgoritimoHuffman
{
    public class Serializa
    {
        String caminho;
        FileStream fs;
        BinaryFormatter bf;

        public Serializa(String caminho)
        {
            this.caminho = caminho;
        }

        public Serializa()
        {
            this.caminho = "/Dados/Documents/NetBeansProjects/Algoritmo_de_Huffman/Algoritimo_de_Huffman/Docarquivo_comp.Data";
        }

        //Serializa um arquivo de forma binaria
        public void Serializar(Data a)
        {
            // Cria o arquivo 
            fs = new FileStream(this.caminho, FileMode.Create);
            // Cria um objeto BinaryFormatter para realizar a serialização
            bf = new BinaryFormatter();
            // Usa o objeto BinaryFormatter para serializar os dados para o arquivo
            bf.Serialize(fs, a);
            // fecha o arquivo
            fs.Close();
            Console.WriteLine("\nArquivo serializado !");
            Console.ReadKey();

        }

        //Serializa um arquivo texto
        public void SerializarString(String a)
        {

            System.IO.File.WriteAllText(this.caminho, a);

            Console.WriteLine("\nArquivo serializado !");
            Console.ReadKey();

        }

        //Lê um arquivo binario e retorna um objeto data
        public Data Desserializar()
        {
			
            // Abre o arquivo para ler os dados
            fs = new FileStream(this.caminho, FileMode.Open);
            // Cria um objeto BinaryFormatter para realizar a dessarialização
            bf = new BinaryFormatter();
            // Cria um objeto para armazenar os dados dessarializados
            Data a;
            // Usa o objeto BinaryFormatter para desserializar os dados do arquivo
            a = (Data)bf.Deserialize(fs);
            // fecha o arquivo
            fs.Close();
            // Exibe o tempo desserializado
            Console.WriteLine("\nArquivo Desserializado!");
            Console.ReadKey();

            return a;
        }

    }
}

