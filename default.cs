using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace PaginaCadastro
{
    public partial class FormCadastro : System.Web.UI.Page
    {


        protected void BTNcadastrar_Click(object sender, EventArgs e)
        {
            String insertSql;

            String conStr = "Data Source=DESKTOP-MF5SPOV\\SQLEXPRESS;Initial Catalog=BDaula1;Integrated Security=True";
            insertSql = "INSERT INTO TBaspnet1(nome,telefone,email) VALUES(@nome,@telefone,@email)";
            SqlConnection conexao = new SqlConnection(conStr);
            SqlCommand sqlComando = new SqlCommand(insertSql, conexao);

            try
            {
                sqlComando.Parameters.Add(new SqlParameter("@nome", txtNome.Text));
                sqlComando.Parameters.Add(new SqlParameter("@telefone", txtTelefone.Text));
                sqlComando.Parameters.Add(new SqlParameter("@email", txtEmail.Text));
                conexao.Open();
                sqlComando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            LimpaText();
        }
        protected void BTNconsultar_Click(object sender, EventArgs e)
        {
            String selectSql;
            var saida = "";

            String conStr = "Data Source=DESKTOP-MF5SPOV\\SQLEXPRESS;Initial Catalog=BDaula1;Integrated Security=True";
            selectSql = "SELECT * FROM TBaspnet1";
            SqlConnection conexao = new SqlConnection(conStr);
            SqlCommand sqlComando2 = new SqlCommand(selectSql, conexao);
            SqlDataReader dataReader;

            try
            {
                conexao.Open();
                dataReader = sqlComando2.ExecuteReader();
                while (dataReader.Read())
                {
                    saida = saida + dataReader.GetValue(0) + " Nome: " + dataReader.GetValue(1) + " Telefone:  " + dataReader.GetValue(2) + " E-mail:  " + dataReader.GetValue(3) + "<br />";
                }

                DIVdadostabela.InnerHtml = saida;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            LimpaText();
        }
        private void LimpaText()
        {
            txtNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }
    }
}