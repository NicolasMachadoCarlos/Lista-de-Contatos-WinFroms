using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    internal static class DbDelete
    {
        public static void ExcluirItem(int ?id)
        {
            string txtCmd = "DELETE FROM contato WHERE id=@id ";

            try
            {
                DbConnection.Open();

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = DbConnection._Connection,
                    CommandText = txtCmd
                };
                               
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
