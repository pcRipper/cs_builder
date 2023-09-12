using DB.PG;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.Serialization;

namespace cs_builder.Libraries.Labs.var_19.lab8
{
    public partial class Form_8 : Form
    {
        DB_PG pg;
        public void init_db_connection()
        {
            pg = new DB_PG();
            var result = pg.connect(new Dictionary<string, string>{
                {"server","localhost" },
                {"port","5433"},
                {"db_name","test_db" },
                {"user_name","postgres" },
                {"password","root" }
            });

            if (result.IsT0)
            {
                pg.SetConnection = result.AsT0;
            }
        }
        public Form_8()
        {
            InitializeComponent();
            init_db_connection();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var result = pg.setQuery(new Npgsql.NpgsqlCommand("SELECT * FROM bank_account"));

            if (result.IsT1)
            {
                MessageBox.Show("Error occured : " + result.AsT1.Message);
                return;
            }

            dataGridView1.DataSource = result.AsT0;
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            var result = pg.setQuery(new Npgsql.NpgsqlCommand("SELECT * FROM bank_account"));

            if (result.IsT1)
            {
                MessageBox.Show("Error occured : " + result.AsT1.Message);
                return;
            }

            List<string> data = new List<string>() { "All" };
            comboBox1.DataSource = data.Concat(result.AsT0.AsEnumerable().Select(row => row[0].ToString()).ToList()).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) return;

            var result = pg.setQuery(new Npgsql.NpgsqlCommand($"SELECT * FROM bank_account WHERE account_id = {comboBox1.SelectedItem};"));

            if (result.IsT1)
            {
                MessageBox.Show("Error occured : " + result.AsT1.Message);
                return;
            }

            if (result.AsT0.Rows.Count != 1)
            {
                MessageBox.Show("There is no record with such index");
                return;
            }

            DataRow data = result.AsT0.Rows[0];
            textBox_aID.Text = data[0].ToString();
            textBox_surname.Text = data[1].ToString();
            textBox_name.Text = data[2].ToString();
            textBox_middleName.Text = data[3].ToString();
            //textBox_DOB.Text = new DateTime(data[4].ToString());
            textBox_DOB.Text = Convert.ToDateTime(data[4]).ToString("yyyy-MM-dd");
            textBox_money.Text = data[5].ToString();
        }

        private void button_update_record_Click(object sender, EventArgs e)
        {
            var result = pg.setQuery(new Npgsql.NpgsqlCommand($"SELECT * FROM bank_account WHERE account_id = {textBox_aID.Text} ;"));

            if (result.IsT1)
            {
                Console.WriteLine("Error occured : " + result.AsT1.Message);
                return;
            }

            if (result.AsT0.Rows.Count != 0)
            {
                string query = $"UPDATE bank_account SET " +
                    $"surname = '{textBox_surname.Text}', " +
                    $"name = '{textBox_name.Text}', " +
                    $"middle_name = '{textBox_middleName.Text}', " +
                    $"dob = '{textBox_DOB.Text}', " +
                    $"amount = {textBox_money.Text} " +
                    $"WHERE account_id = {textBox_aID.Text}";

                result = pg.setQuery(new Npgsql.NpgsqlCommand(query));

                if (result.IsT1)
                {
                    Console.WriteLine("Error occured : " + result.AsT1.Message);
                }
            }
            else
            {
                string query = $"INSERT INTO bank_account VALUES (" +
                    $"{textBox_aID.Text}," +
                    $"'{textBox_surname.Text}'," +
                    $"'{textBox_name.Text}'," +
                    $"'{textBox_middleName.Text}'," +
                    $"'{textBox_DOB.Text}'," +
                    $"{textBox_money.Text}" +
                    $")";


                result = pg.setQuery(new Npgsql.NpgsqlCommand(query));

                if (result.IsT1)
                {
                    Console.WriteLine("Error occured : " + result.AsT1.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM bank_account";
            if (comboBox1.SelectedIndex != 0)
            {
                query += $" WHERE account_id = {comboBox1.Text}";
            }


            var result = pg.setQuery(new Npgsql.NpgsqlCommand(query + ";"));

            if (result.IsT1)
            {
                MessageBox.Show("Error occured : " + result.AsT1.Message);
            }
        }
    }
}
