using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Lab_4
{
    public partial class Form1 : Form
    {
        private SqlConnection sqlConnection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashbox_AeroflotDataSet4.Table_of_Flights". При необходимости она может быть перемещена или удалена.
            this.table_of_FlightsTableAdapter3.Fill(this.cashbox_AeroflotDataSet4.Table_of_Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashbox_AeroflotDataSet3.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.cashbox_AeroflotDataSet3.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashbox_AeroflotDataSet2.Table_of_Flights". При необходимости она может быть перемещена или удалена.
            this.table_of_FlightsTableAdapter2.Fill(this.cashbox_AeroflotDataSet2.Table_of_Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashbox_AeroflotDataSet1.Table_of_Flights". При необходимости она может быть перемещена или удалена.
            this.table_of_FlightsTableAdapter1.Fill(this.cashbox_AeroflotDataSet1.Table_of_Flights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cashbox_AeroflotDataSet.Table_of_Flights". При необходимости она может быть перемещена или удалена.
            this.table_of_FlightsTableAdapter.Fill(this.cashbox_AeroflotDataSet.Table_of_Flights);
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["cashbox_Aeroflot"].ConnectionString);

            sqlConnection.Open();
        }
        private void Number_TextChanged(object sender, EventArgs e)
        {
            if (Number_box.Text.Length == 0 || Direction_box.Text.Length == 0 || Time_box.Text.Length == 0 || Days_box.Text.Length == 0)
                INSERT_button.Enabled = false;
            else
                INSERT_button.Enabled = true;
        }
        private void INSERT_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 8; ++i)
            {
                SqlCommand command = new SqlCommand($"INSERT INTO [Table_of_Flights] (Number, Direction, Stops, Time, Days, Place, Status) VALUES (@Number, @Direction, @Stops, @Time, @Days, @Place, @Status)", sqlConnection);

                DateTime date = DateTime.Parse(Days_box.Text);


                command.Parameters.AddWithValue("Number", Number_box.Text);
                command.Parameters.AddWithValue("Direction", Direction_box.Text);
                command.Parameters.AddWithValue("Stops", Stops_box.Text);
                command.Parameters.AddWithValue("Time", Time_box.Text);
                command.Parameters.AddWithValue("Days", $"{date.Month}/{date.Day}/{date.Year}");
                command.Parameters.AddWithValue("Place", i);
                command.Parameters.AddWithValue("Status", "free");

                command.ExecuteNonQuery();
            }
            SqlCommand command_City = new SqlCommand($"INSERT INTO [Table] (City) VALUES (@City)", sqlConnection);
            command_City.Parameters.AddWithValue("City", Direction_box.Text);

            command_City.ExecuteNonQuery();
        }

        private void SELECT_Click(object sender, EventArgs e)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT * FROM [Table_of_Flights] WHERE Direction = '{comboBox1.Text}' AND Status = 'free' ", sqlConnection);

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            dataGridView1.DataSource = dataSet.Tables[0];
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"UPDATE Table_of_Flights SET Status = 'busy' WHERE Direction = '{comboBox1.Text}' AND Place = '{comboBox2.Text}'", sqlConnection);
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Вы забронировали место на рейсе в город " + comboBox1.Text + ". Ваше место " + comboBox2.Text, "ЧЕК");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0)
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}