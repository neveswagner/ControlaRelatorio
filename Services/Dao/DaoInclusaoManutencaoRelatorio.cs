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
    public class DaoInclusaoManutencaoRelatorio : ConexaoBancoMySQL
    {
        public void SalvarRelatorio(ManutencaoRelatorio m)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "INSERT INTO relatorio" +
                                     "(requisito," +
                                     " cliente, " +
                                     "cliente_atualizado, " +
                                     "atendente, " +
                                     "pendente_status, " +
                                     "observacao ," +
                                     "dtainclusao) " +
                                     "VALUES(?, ?, ?, ?, ?, ?, ?);";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito", m.Requisito));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente", m.Cliente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente_atualizado", m.ClienteAtualizado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("atendente", m.Atendente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pendente_status", m.PendenteStatus));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("observacao", m.Observacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtainclusao", m.DtaInclusao));

                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }

        public void EditarRelatorio(ManutencaoRelatorio m)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "UPDATE relatorio SET " +
                                     "requisito  = @requisito, " +
                                     "cliente  = @cliente,  " +
                                     "cliente_atualizado = @cliente_atualizado,  " +
                                     "atendente  = @atendente ,  " +
                                     "pendente_status = @pendente_status,  " +
                                     "observacao = @observacao,  " +
                                     "dtainclusao = @dtainclusao,  " +
                                     "requisito_atualizacao = @requisito_atualizacao," +
                                     "requisito_correcao = @requisito_correcao " +
                                     "WHERE id_relatorio = @id_relatorio";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito", m.Requisito));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente", m.Cliente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente_atualizado", m.ClienteAtualizado));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("atendente", m.Atendente));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("pendente_status", m.PendenteStatus));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("observacao", m.Observacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dtainclusao", m.DtaInclusao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito_atualizacao", m.RequisitoAtualizacao));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito_correcao", m.RequisitoCorrecao));

                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_relatorio", m.Id_relatorio));


                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }



        public void BaixarRelatorio(ManutencaoRelatorio m)
        {

            try
            {

                MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
                conn = new MySqlConnection(connectionString);
                String insertDados = "UPDATE relatorio SET pendente_status = 'S',  observacaoBaixa = @observacaoBaixa,  requisito_correcao = @reqCorrecao  WHERE id_relatorio = @id_relatorio";
                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(insertDados, conn);

                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("observacaoBaixa", m.ObservacaoBaixa));
                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("reqCorrecao", m.RequisitoCorrecao));

                cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("id_relatorio", m.Id_relatorio));


                cmd.Prepare();

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("Relatorio Baixado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuario, verifique a conexão com o banco de dados: " + ex.ToString());

            }
        }





        public List<ManutencaoRelatorio> BuscarRelatoriolienteAtualizado(ManutencaoRelatorio m)
        {
            List<ManutencaoRelatorio> BuscarRelatorio = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT id_relatorio, " +
                                    "dtainclusao,  " +
                                    "requisito, " +
                                    "cliente, " +
                                    "atendente,  " +
                                    "pendente_status, " +
                                    "observacao," +
                                    "cliente_atualizado," +
                                    "pendente_status," +
                                    "requisito_correcao," +
                                    "requisito_atualizacao " +
                                    "FROM relatorio  WHERE cliente_atualizado = 'S' and pendente_status = 'N'" +
                                    "and requisito_correcao = '' ;";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    novo.Id_relatorio = (int)reader["id_relatorio"];
                    novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                    novo.Requisito = reader["requisito"].ToString();
                    novo.Cliente = reader["cliente"].ToString();
                    novo.Atendente = reader["atendente"].ToString();
                    novo.PendenteStatus = reader["pendente_status"].ToString();
                    novo.Observacao = reader["observacao"].ToString();
                    novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                    novo.RequisitoCorrecao = reader["requisito_correcao"].ToString();
                    novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();







                    BuscarRelatorio.Add(novo);


                }

                conn.Close();
                return BuscarRelatorio;
            }
            finally
            {
                conn.Close();
            }
        }



        public List<ManutencaoRelatorio> BuscarRelatoriolienteNaoAtualizado(ManutencaoRelatorio m)
        {
            List<ManutencaoRelatorio> BuscarRelatorio = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT id_relatorio, " +
                                    "dtainclusao,  " +
                                    "requisito, " +
                                    "cliente, " +
                                    "atendente,  " +
                                    "pendente_status, " +
                                    "cliente_atualizado," +
                                    "pendente_status," +
                                    "requisito_correcao," +
                                    "requisito_atualizacao, " +
                                    "observacao FROM relatorio  WHERE cliente_atualizado = 'N'" +
                                    "and pendente_status = 'N'" +
                                    "and requisito_correcao = '' ;";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    novo.Id_relatorio = (int)reader["id_relatorio"];
                    novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                    novo.Requisito = reader["requisito"].ToString();
                    novo.Cliente = reader["cliente"].ToString();
                    novo.Atendente = reader["atendente"].ToString();
                    novo.PendenteStatus = reader["pendente_status"].ToString();
                    novo.Observacao = reader["observacao"].ToString();
                    novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                    novo.RequisitoCorrecao = reader["requisito_correcao"].ToString();
                    novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();






                    BuscarRelatorio.Add(novo);


                }

                conn.Close();
                return BuscarRelatorio;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ManutencaoRelatorio> BuscarRelatorioPendenteTempoAtualizado(ManutencaoRelatorio m)
        {
            List<ManutencaoRelatorio> BuscarRelatorio = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT id_relatorio, " +
                                    "dtainclusao,  " +
                                    "requisito, " +
                                    "cliente, " +
                                    "atendente,  " +
                                    "pendente_status, " +
                                    "observacao, " +
                                    "cliente_atualizado," +
                                    "pendente_status," +
                                    "requisito_correcao," +
                                    "requisito_atualizacao " +
                                    "FROM relatorio  " +
                                    "WHERE cliente_atualizado = 'S'" +
                                    "and pendente_status = 'N'" +
                                    "and requisito_correcao = ''  " +
                                    "AND dtainclusao  BETWEEN '2000-01-01' AND CURRENT_DATE -@dias;";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("dias", m.DiasCountAtendente));

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    novo.Id_relatorio = (int)reader["id_relatorio"];
                    novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                    novo.Requisito = reader["requisito"].ToString();
                    novo.Cliente = reader["cliente"].ToString();
                    novo.Atendente = reader["atendente"].ToString();
                    novo.PendenteStatus = reader["pendente_status"].ToString();
                    novo.Observacao = reader["observacao"].ToString();
                    novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                    novo.RequisitoCorrecao = reader["requisito_correcao"].ToString();
                    novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();


                    BuscarRelatorio.Add(novo);


                }

                conn.Close();
                return BuscarRelatorio;
            }
            finally
            {
                conn.Close();
            }
        }

        public List<ManutencaoRelatorio> CountAtendente(ManutencaoRelatorio m)
        {
            List<ManutencaoRelatorio> BuscarRelatorio = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT DISTINCT atendente, " +
                                    "COUNT(*) AS quantidade " +
                                    "FROM relatorio " +
                                    "WHERE pendente_status = 'N' " +
                                    "and requisito_correcao = ''  " +
                                    "AND cliente_atualizado = 'S' " +
                                    "GROUP BY atendente " +
                                    "HAVING COUNT(atendente) > 0 " +
                                    "ORDER BY quantidade DESC; ";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    //  novo.Id_relatorio = (int)reader["id_relatorio"];                  
                    novo.Atendente = reader["atendente"].ToString();
                    novo.QuantidadeAtendente = reader["quantidade"].ToString();


                    BuscarRelatorio.Add(novo);

                }

                conn.Close();
                return BuscarRelatorio;
            }
            finally
            {
                conn.Close();
            }
        }



        public List<ManutencaoRelatorio> PesquisarRequisito(ManutencaoRelatorio m)
        {
            List<ManutencaoRelatorio> PesquisarRequisito = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT id_relatorio, " +
                                    "dtainclusao,  " +
                                    "requisito, " +
                                    "cliente, " +
                                    "atendente,  " +
                                    "pendente_status, " +
                                    "observacao," +
                                    "cliente_atualizado," +
                                    "pendente_status," +
                                    "requisito_correcao," +
                                    "requisito_atualizacao " +
                                    "FROM relatorio " +
                                    "where requisito = @requisito;";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito", m.Requisito));
            

            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    novo.Id_relatorio = (int)reader["id_relatorio"];
                    novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                    novo.Requisito = reader["requisito"].ToString();
                    novo.Cliente = reader["cliente"].ToString();
                    novo.Atendente = reader["atendente"].ToString();
                    novo.PendenteStatus = reader["pendente_status"].ToString();
                    novo.Observacao = reader["observacao"].ToString();
                    novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                    novo.RequisitoCorrecao = reader["requisito_correcao"].ToString();
                    novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();







                    PesquisarRequisito.Add(novo);


                }

                conn.Close();
                return PesquisarRequisito;
            }
            finally
            {
                conn.Close();
            }
        }


        



        public List<ManutencaoRelatorio> PesquisarRequisitoAtendenteCliente(string Atendente, string Requisito, string Cliente, string StatusReq)
        {
            List<ManutencaoRelatorio> PesquisarRequisitoAtendenteCliente = new List<ManutencaoRelatorio>();
            MySqlConnection conn = new ConexaoBancoMySQL().getConnection();
            conn = new MySqlConnection(connectionString);
            String selecionaTodos = "SELECT id_relatorio, " +
                                    "dtainclusao,  " +
                                    "requisito, " +
                                    "cliente, " +
                                    "atendente,  " +
                                    "pendente_status, " +
                                    "observacao," +
                                    "cliente_atualizado," +
                                    "pendente_status," +
                                    "requisito_correcao," +
                                    "requisito_atualizacao " +
                                    "FROM relatorio " +
                                    "where requisito like '%" + @Requisito + "%'" +
                                    "and pendente_status like '%" + @StatusReq + "%'"  +
                                    "and atendente like '%" + @Atendente + "%'" +
                                    "and cliente like '%" + @Cliente + "%'";
            conn.Open();
            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(selecionaTodos, conn);
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("requisito", Requisito));
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("cliente", Cliente));
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("atendente", Atendente));
            cmd.Parameters.Add(new MySql.Data.MySqlClient.MySqlParameter("statusReq", StatusReq));








            //MessageBox.Show(Convert.ToString();
            try
            {

                MySqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    ManutencaoRelatorio novo = new ManutencaoRelatorio();

                    novo.Id_relatorio = (int)reader["id_relatorio"];
                    novo.DtaInclusao = Convert.ToDateTime(reader["dtainclusao"].ToString());
                    novo.Requisito = reader["requisito"].ToString();
                    novo.Cliente = reader["cliente"].ToString();
                    novo.Atendente = reader["atendente"].ToString();
                    novo.PendenteStatus = reader["pendente_status"].ToString();
                    novo.Observacao = reader["observacao"].ToString();
                    novo.ClienteAtualizado = reader["cliente_atualizado"].ToString();
                    novo.RequisitoCorrecao = reader["requisito_correcao"].ToString();
                    novo.RequisitoAtualizacao = reader["requisito_atualizacao"].ToString();







                    PesquisarRequisitoAtendenteCliente.Add(novo);


                }

                conn.Close();
                return PesquisarRequisitoAtendenteCliente;
            }
            finally
            {
                conn.Close();
            }
        }


    }
}
