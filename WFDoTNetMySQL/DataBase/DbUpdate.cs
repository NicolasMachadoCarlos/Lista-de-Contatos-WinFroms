using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFDoTNetMySQL;

namespace DataBase
{
    internal class DbUpdate
    {
        public static void UpadteData(int ?id, string nome, string email, string telefone)
        {
            string txtCmd = "UPDATE contato SET " +
                             "nome=@nome, email=@email, telefone=@telefone " +
                             "Where id=@id";

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
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
