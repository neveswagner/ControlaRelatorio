using MySql.Data.MySqlClient;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Services.Dao
{
    public class DaoPrevisao : ConexaoBancoMySQL
    {

        public void IncluirPrevisao(Previsao p)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO previsao" +
                                     "(requisito," +
                                     " cliente, " +
                                     "cliente_atualizado, " +
                                     "atendente, " +
                                     "concluido_status, " +
                                     "observacao ," +
                                     "dtainclusao," +
                                     "dtaprevisao," +
                                     "baixado_programacao," +
                                     "requisito_atualizacao) " +
                                     "VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito", p.Requisito));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente", p.Cliente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente_atualizado", p.ClienteAtualizado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("atendente", p.Atendente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("concluido_status", p.ConcluidoStatus));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("observacao", p.Observacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtainclusao", p.DtaInclusao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtaprevisao", p.DtaPrevisao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("baixado_programacao", p.BaixadoProgramacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisitoatualizacao", p.RequisitoAtualizacao));



                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

            public List<Previsao> AbertoProgramacao(Previsao p)
            {
                List<Previsao> AbertoProgramacao = new List<Previsao>();
                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String selecionaTodos = "SELECT Mes, Dias, id_previsao, requisito, dtainclusao, dtaprevisao, cliente, atendente, cliente_atualizado, requisito_atualizacao, concluido_status, observacao, baixado_programacao FROM(SELECT id_previsao, requisito, dtainclusao, dtaprevisao, cliente, atendente, cliente_atualizado, requisito_atualizacao, concluido_status, observacao, baixado_programacao,  TIMESTAMPDIFF(     MONTH,     dtaprevisao + INTERVAL TIMESTAMPDIFF(YEAR, dtaprevisao, CURRENT_DATE) YEAR,     CURRENT_DATE  ) AS Mes,  TIMESTAMPDIFF(    DAY,     dtaprevisao + INTERVAL TIMESTAMPDIFF(MONTH, dtaprevisao, CURRENT_DATE) MONTH,     CURRENT_DATE   ) AS Dias FROM previsao   ) t WHERE concluido_status = 'N' AND Dias > '0' ORDER BY Mes DESC;; ";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

                try
                {

                    MySqlDataReader reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                    Previsao novo = new Previsao();

                        novo.Id_relatorio = (int)reader["id_previsao"];
                        novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                        novo.DtaPrevisao = Convert.ToDateTime(reader["dtaprevisao"].ToString());
                        novo.Requisito = reader["requisito"].ToString();
                        novo.Cliente = reader["cliente"].ToString();
                        novo.Atendente = reader["atendente"].ToString();
                        novo.ConcluidoStatus = reader["concluido_status"].ToString();
                        novo.Observacao = reader["observacao"].ToString();
                        novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                        novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();
                        novo.BaixadoProgramacao = reader["baixado_programacao"].ToString();
                        novo.MesPrevisao = reader["Mes"].ToString();
                        novo.DiasPrevisao = reader["Dias"].ToString();








                    AbertoProgramacao.Add(novo);


                    }

                    conn.Close();
                    return AbertoProgramacao;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }

