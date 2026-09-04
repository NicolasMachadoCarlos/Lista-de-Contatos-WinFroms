using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public static class DbRead
    {
        public static List<string[]> ReadData(string txt)
        {
            var data = new List<string[]>();

            string txtCmd;
            
            if (!String.IsNullOrWhiteSpace(txt))
            {
                txtCmd = "SELECT * FROM contato WHERE nome LIKE @nome";
            }
            else 
            {
                txtCmd = "SELECT * FROM contato";
            }

            try
            {
                DbConnection.Open(); 

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = DbConnection._Connection,
                    CommandText = txtCmd
                };

                if (!String.IsNullOrWhiteSpace(txt))
                {
                    cmd.Parameters.AddWithValue("@nome", "%" + txt + "%");
                }
                                                
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data.Add(new string[]
                    {
                        reader[0].ToString(),
                        reader[1].ToString(),
                        reader[2].ToString(),
                        reader[3].ToString()
                    });
                }

                reader.Close();
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

            return data;
        }
    }

}
