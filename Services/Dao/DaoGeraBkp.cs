using MySql.Data;
using MySql.Data.MySqlClient;
using Services.Models;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Services.Dao
{

    public class DaoGeraBkp  : ConexaoBancoMySQL
    {

        public void GeraBkpAutomatico()
        {

            try
            {

                String servidor = "";
                String porta = "";
                String usuario = "";
                String senha = "";
                String banco = "";
                String local = "";

                //faz a leitura do arquivo config.dat e captura o valor de cada linha.
                int contador = 0;
                string linha;
                System.IO.StreamReader file = new System.IO.StreamReader(@"config.dat");
                while ((linha = file.ReadLine()) != null)
                {
                    if (contador == 0) servidor = linha;
                    if (contador == 1) porta = linha;
                    if (contador == 2) usuario = linha;
                    if (contador == 3) senha = linha;
                    if (contador == 4) banco = linha;
                    if (contador == 5) local = linha;
                    contador++;
                }
                file.Close();
                // fim da leitura do arquivo.

                string constring = "server=" + servidor + ";port=" + porta +  ";user=" + usuario + ";pwd=" + senha + ";database=" + banco + ";";
                

                constring += "charset=utf8;convertzerodatetime=true;";

                // define o nome do arquivo de backup de acordo com a data e hora.
                string dia = DateTime.Now.Day.ToString();
                string mes = DateTime.Now.Month.ToString();
                string ano = DateTime.Now.Year.ToString();
                string hora = DateTime.Now.ToLongTimeString().Replace(":", "");
                string nomeDoArquivo = ano + mes + dia + "_" + hora;
                // fim
                

                // gera o conteúdo do arquivo de backup e salva no local definido no config.dat
                string arquivo = local + "\\" + nomeDoArquivo + ".sql";
                using (MySqlConnection conn = new MySqlConnection(constring))
                {
                    conn.Close();
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmd))
                        {
                            
                            cmd.Connection = conn;
                            conn.Open();
                            mb.ExportToFile(arquivo);
                            conn.Close();
                        }
                    }
                }
/*
                //   string pastaParaZipar = @"C:\Users\LINQ\pasta-zip";
                // string caminhoZip = @"C:\Users\LINQ\arquivo-novo.zip";
                MessageBox.Show(local);
                string teste = local + "\\" + nomeDoArquivo;

                MessageBox.Show(nomeDoArquivo);
                MessageBox.Show(arquivo);
                ZipFile.CreateFromDirectory(arquivo, teste + ".zip");


                //string nomeArquivo = @"C:\Users\LINQ\arquivo.zip";

                
    */
                MessageBox.Show("Backup realizado com Sucesso ! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao Fazer Backup: " + ex.ToString());

            }
        }



    }
}
