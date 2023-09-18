using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extensions;

namespace cs_builder.Libraries.Labs.var_14.lab8
{
    public static partial class Extensions
    {
        public static string setMaxLength(this string str,int maxLength)
        {
            return str.Substring(0,Math.Min(str.Length,maxLength));
        }
    }
    public partial class Form_ADO : Form
    {
        DB db;
        public Form_ADO()
        {
            InitializeComponent();
            db = new DB();
            var result = db.connect("Host=localhost;Port=5432;Database=test_db;Username=postgres;Password=root");
            if (result != null)
            {
                MessageBox.Show(result.Message);
                Application.Exit();
            }

            radioButton1.Click += new EventHandler(delegate (object? sender,EventArgs e){
                radioButton1.Checked = !radioButton1.Checked;
            });
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"{e.RowIndex}x{e.ColumnIndex}");
        }

        private void button_updateElement_Click(object sender, EventArgs e)
        {
            int ID;
            if (!Int32.TryParse(textBox1.Text, out ID))
            {
                MessageBox.Show("The id field is inccorect!");
                return;
            }


            var result = db.pushQuery($"SELECT * FROM passenger WHERE id = {ID}");

            if (result.IsT0)
            {
                MessageBox.Show(result.AsT0.Message);
                return;
            }

            if (result.AsT1.Rows.Count == 0)
            {
                string query = $"INSERT INTO passenger VALUES (" +
                    $"{ID}," +
                    $"'{textBox2.Text.setMaxLength(125)}'," +
                    $"'{textBox3.Text.setMaxLength(50)}'," +
                    $"'{textBox4.Text.setMaxLength(50)}'," +
                    $"'{textBox5.Text}'," +
                    $"'{textBox6.Text}'," +
                    $"'{textBox7.Text.setMaxLength(3)}'," +
                    $"'{(radioButton1.Checked ? "True" : "False")}'" +
                    $");";

                result = db.pushQuery(query);

                if (result.IsT0)
                {
                    MessageBox.Show(result.AsT0.Message);
                    return;
                }
            }
            else
            {
                string query = $"UPDATE passenger SET " +
                    $"name = '{textBox2.Text.setMaxLength(125)}'," +
                    $"from_place = '{textBox3.Text.setMaxLength(50)}'," +
                    $"to_place = '{textBox4.Text.setMaxLength(50)}'," +
                    $"date_out = '{textBox5.Text}'," +
                    $"carriage = '{textBox6.Text}'," +
                    $"seat = '{textBox7.Text.setMaxLength(3)}'," +
                    $"luggage = '{(radioButton1.Checked ? "True" : "False")}'" +
                    $" WHERE id = {ID};";

                result = db.pushQuery(query);

                if (result.IsT0)
                {
                    MessageBox.Show(result.AsT0.Message);
                    return;
                }
            }
        }

        private void button_deleteElement_Click(object sender, EventArgs e)
        {
            int ID;
            if (!Int32.TryParse(textBox1.Text, out ID))
            {
                MessageBox.Show("The id field is inccorect!");
                return;
            }

            var result = db.pushQuery($"DELETE FROM passenger WHERE id = {ID}");

            if (result.IsT0)
            {
                MessageBox.Show(result.AsT0.Message);
                return;
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            var result = db.pushQuery("SELECT * FROM passenger");
            if (result.IsT0)
            {
                MessageBox.Show(result.AsT0.Message);
                return;
            }

            dataGridView1.DataSource = result.AsT1;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;

            var result = db.pushQuery($"SELECT * FROM passenger WHERE id = {(int)dataGridView1[e.ColumnIndex, e.RowIndex].Value}");
            if (result.IsT0)
            {
                MessageBox.Show(result.AsT0.Message);
                return;
            }
            if (result.AsT1.Rows.Count == 0)
            {
                MessageBox.Show("There is no record with such index!\nUpdate your List for new information");
                return;
            }

            var data = result.AsT1.Rows[0];

            textBox1.Text = data[0].ToString();
            textBox2.Text = data[1].ToString();
            textBox3.Text = data[2].ToString();
            textBox4.Text = data[3].ToString();
            textBox5.Text = Convert.ToDateTime(data[4]).ToString("yyyy-MM-dd");
            textBox6.Text = data[5].ToString();
            textBox7.Text = data[6].ToString();
            radioButton1.Checked = data[7].ToString() == "True";

        }
    }
}
