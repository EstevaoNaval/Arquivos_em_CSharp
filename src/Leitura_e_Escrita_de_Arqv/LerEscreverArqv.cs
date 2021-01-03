using System;
using System.IO;

class LerEscreverArqv
{
    static void Main(string[] args)
    {
        // Crio uma váriavel com o caminho do arquivo.
        string strCaminhoArqv = @"./src/poema.txt";

        // Abre o arquivo poema.txt e concede permissão de leitura
        using(FileStream arqv = new FileStream(strCaminhoArqv, FileMode.Open, FileAccess.Read)){

            // Permite a leitura do arquivo
            using(StreamReader leitor = new StreamReader(arqv)){
                string linha = "";
                    
                while(linha != null){
                    // Lê a linha e desce para a próxima.
                    linha = leitor.ReadLine();
                        
                    // Escreve o valor contido na váriavel linha
                    Console.WriteLine(linha);
                }
            }
        }
            
        // Abre o arquivo poema.txt e concede permissão de escrita
        using (FileStream arqv = new FileStream(strCaminhoArqv, FileMode.Append, FileAccess.Write))
        {
            // Permite a escrita do arquivo
            using(StreamWriter escritor = new StreamWriter(arqv)){

                escritor.WriteLine("");
                escritor.WriteLine("Adendo 01");
                escritor.WriteLine("Este é um dos poemas mais famosos e manjados do Brasil.");

                Console.WriteLine("Arquivo poema.txt atualizado.");
            }
        } 
    }
}

