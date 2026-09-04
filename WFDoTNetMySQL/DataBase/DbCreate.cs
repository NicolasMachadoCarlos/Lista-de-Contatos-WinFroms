using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFDoTNetMySQL;

namespace DataBase
{
    public static class DbCreate
    {      
        public static void InsertData(string nome, string email, string telefone)
        {
            string txtCmd = "INSERT INTO contato (nome, email, telefone) VALUES (@nome, @email, @telefone)";

            try
            {
                DbConnection.Open();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = DbConnection._Connection,
                    CommandText = txtCmd
                };
                
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                              
                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro "+ ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                DbConnection.Close();
            }

        }
    }

}
