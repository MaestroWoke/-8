using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 


namespace _8
{
    public partial class Form4 : Form
    {
        SqlConnection sqlConnection;
        public Form4()
        {
            InitializeComponent();
        }

        private async void Form4_Load_1(object sender, EventArgs e)
        {
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\УЧЕБА\С#\№8\PRACTICE8.MDF;Integrated Security=True";
            //sqlConnection = new SqlConnection(connectionString);
           //await sqlConnection.OpenAsync();
            SqlDataReader sqlReader = null;
            SqlCommand command = new SqlCommand("SELECT * FROM Base", sqlConnection);
            try
            {
                while (await sqlReader.ReadAsync())
                {
                    string Idmail = sqlReader.GetString(0);
                    string IdName = sqlReader.GetString(1);
                    string IdSurname = sqlReader.GetString(2);
                    string IdPas = sqlReader.GetString(3);
                    listBox1.Items.Add("Электронная почта: " + Idmail + "; " +
                                        "Имя пользователя: " + IdName + "; " +
                                        "Фамилия: " + IdSurname + "; " +
                                        "Пароль: " + IdPas);
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            Convert.ToString(sqlReader[0]),
                            Convert.ToString(sqlReader[1]),
                            Convert.ToString(sqlReader[2]),
                            Convert.ToString(sqlReader[3])
                    });
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlReader != null)
                {
                    sqlReader.Close();
                }
            }
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
