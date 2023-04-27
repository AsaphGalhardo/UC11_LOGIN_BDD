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

namespace UC11_LOGIN_BDD
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando; 


        public Form1()
        {
            InitializeComponent();
             servidor = "Server=localhost;Database=login_bdd;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
             comando = conexao.CreateCommand();
        }

        private void buttonENTRAR_Click(object sender, EventArgs e)
        {

            try
            {
                conexao.Open();
              comando.CommandText = "SELECT usuario, senha FROM tbl_usuarios WHERE usuario =  '" + textBoxUSUARIO.Text + "' AND senha = '" + textBoxSENHA.Text + "';";   

                MySqlDataReader resultado = comando.ExecuteReader();
                if (resultado.Read())
                {
                    MessageBox.Show("Usuário e senha corretos!"); 
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha incorretos!");
                }                                                                  

            }

            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            finally
            {
                conexao.Close();
            }
        }



        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
           
            comando.CommandText = "INSERT INTO tbl_usuarios(usuario, senha) VALUES ('" + textBoxUSUARIO.Text  + " ', '" + textBoxSENHA.Text + "');";
            try
            {
                conexao.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                //MessageBox.Show(erro.Message);
                MessageBox.Show("Erro ao cadastrar novo usuário. Fale com o administrador do sistema");
            }
            finally
            {
                conexao.Close();   
            }
        }
    }
}
