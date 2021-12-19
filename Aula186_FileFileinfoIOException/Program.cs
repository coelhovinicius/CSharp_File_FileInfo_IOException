/* FILE, FILE INFO E IOEXCEPTION */

using System;
using System.IO;

namespace Aula186_FileFileinfoIOException
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt"; // Caminho do arquivo desejado
            // string sourcePath = "c:\\temp\\file1.txt"; // sintaxe alternativa
            string targetPath = @"c:\temp\file2.txt";
            // string targetPath = "c:\\temp\\file2.txt"; // sintaxe alternativa

            try // Bloco para inserir todas as operacoes com arquivos
            {
                // Instanciar objeto associado ao arquivo que esta no caminho informado para "sourcePath"
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Copia para o caminho informado para "targetPath"
                string[] lines = File.ReadAllLines(sourcePath); /* Le todas as linhas do arquivo e guarda 
                                                                 * cada linha como um elemento do vetor. */
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR!");
                Console.WriteLine(e.Message); // Imprime a mensagem de erro padrao

            }
        }
    }
}
