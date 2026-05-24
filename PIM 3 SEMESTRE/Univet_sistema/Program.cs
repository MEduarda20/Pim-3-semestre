using System;
using System.Data;
using Dapper;
using UNIVET.Data;
using UNIVET.Models;

namespace UNIVET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A iniciar a consulta na base de dados do UNIVET...");

            // 1. Criar a instância da nossa classe de conexão
            var configConexao = new Conexao();

            // 2. Abrir a ligação à base de dados de forma segura
            using (IDbConnection db = configConexao.ObterConexao())
            {
                try
                {
                    // Query SQL utilizando os nomes exatos das colunas padronizadas
                    // O "AS" ajuda o Dapper a mapear diretamente para as propriedades em C#
                    string sql = "SELECT cd_tutor AS CdTutor, nm_tutor AS NmTutor, nr_cpf AS NrCpf, nr_telefone AS NrTelefone, ds_email AS DsEmail FROM tutor WHERE cd_tutor = @id";

                    // 3. Executar a consulta com o Dapper passando o ID do João da Silva (1)
                    var tutor = db.QueryFirstOrDefault<Tutor>(sql, new { id = 1 });

                    // 4. Exibir os resultados na consola
                    if (tutor != null)
                    {
                        Console.WriteLine("\n=================================");
                        Console.WriteLine("   TUTOR ENCONTRADO COM SUCESSO  ");
                        Console.WriteLine("=================================");
                        Console.WriteLine($"Código:    {tutor.CdTutor}");
                        Console.WriteLine($"Nome:      {tutor.NmTutor}");
                        Console.WriteLine($"CPF:       {tutor.NrCpf}");
                        Console.WriteLine($"Telefone:  {tutor.NrTelefone}");
                        Console.WriteLine($"E-mail:    {tutor.DsEmail}");
                        Console.WriteLine("=================================\n");
                    }
                    else
                    {
                        Console.WriteLine("Aviso: Nenhum tutor foi encontrado com o código especificado.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro crítico de ligação: {ex.Message}");
                    Console.WriteLine("Verifique se a palavra-passe do MySQL está correta no ficheiro Conexao.cs e se o servidor está ativo.");
                }
            }
        }
    }
}