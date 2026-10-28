using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DataBase;

namespace WFDoTNetMySQL
{
    public partial class Form1 : Form
    {
        private int? idSelecionado = null;
        private string caracteristicaSelecionada = null;

        public Form1()
        {
            InitializeComponent();

            lstContato.View = View.Details;
            lstContato.GridLines = true;
            lstContato.AllowColumnReorder = false;
            lstContato.FullRowSelect = true;


            lstContato.Columns.Add("Id", 30, HorizontalAlignment.Left);
            lstContato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lstContato.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            lstContato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);


        }

        private void InsertItens(List<string[]> list)
        {
            foreach (var item in list)
            {
                ListViewItem listView = new ListViewItem(item[0]);
                listView.SubItems.Add(item[1]);
                listView.SubItems.Add(item[2]);
                listView.SubItems.Add(item[3]);
                lstContato.Items.Add(listView);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (idSelecionado == null)
                {
                    DbCreate.InsertData(txtNome.Text, txtEmail.Text, txtTelefone.Text);

                    MessageBox.Show("Dados inseridos com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DbUpdate.UpadteData(idSelecionado, txtNome.Text, txtEmail.Text, txtTelefone.Text);

                    MessageBox.Show("Dados atualizados com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    string txtSearch = caracteristicaSelecionada;
                                       
                    var data = DbRead.ReadData(txtSearch);

                    lstContato.Items.Clear();

                    InsertItens(data);
                                                                          
                }
                
                idSelecionado = null;
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string txtSearch = txtBuscar.Text;
            caracteristicaSelecionada = txtSearch;

            try
            {
                var data = DbRead.ReadData(txtSearch);

                lstContato.Items.Clear();

                InsertItens(data);

                txtBuscar.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void lstContato_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itensSelecionados = lstContato.SelectedItems;

            foreach (ListViewItem item in itensSelecionados) 
            {
                idSelecionado = int.Parse(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
                                              
            }
        }

        private void Novo_Click(object sender, EventArgs e)
        {
            idSelecionado = null;
            caracteristicaSelecionada = null;
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
        }
    }
}
