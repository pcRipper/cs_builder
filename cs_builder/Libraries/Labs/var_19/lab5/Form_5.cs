using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

#pragma warning disable SYSLIB0011

namespace cs_builder.Libraries.Labs.var_19.lab5
{
    public partial class Form_5 : Form
    {
        static FileStream fs;
        static Star star;

        public Form_5()
        {
            InitializeComponent();
            pictureBox2.Image = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            star = new Star();
        }
        private bool check_file(string path)
        {

            if (path.Length == 0)
            {
                MessageBox.Show("Wrong file path input!");
                return false;
            }

            FileInfo info = new FileInfo(path);

            if (!info.Exists)
            {
                MessageBox.Show("File is missing");
                return false;
            }

            return true;
        }

        private void set_fields()
        {
            textBox1.Text = star.a.ToString();
            textBox2.Text = star.b.ToString();
        }

        XmlSerializer formatter_xml = new XmlSerializer(typeof(Star));
        BinaryFormatter formatter_binary = new BinaryFormatter();

        private void binary_serialize(object sender, EventArgs e)
        {
            if (!check_file(textBox_path.Text)) return;

            try
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    formatter_binary.Serialize(fs, star);
                }
            }catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xml_serialize(object sender, EventArgs e)
        {
            if (!check_file(textBox_path.Text)) return;

            try
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Create))
                {
                    formatter_xml.Serialize(fs, star);
                }
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
        }

        private void binary_deserialize(object sender, EventArgs e)
        {
            if (!check_file(textBox_path.Text)) return;

            try
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    star = (Star)formatter_binary.Deserialize(fs);
                    set_fields();
                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void xml_deserialize(object sender, EventArgs e)
        {
            if (!check_file(textBox_path.Text)) return;

            try
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    star = (Star)formatter_xml.Deserialize(fs);
                    set_fields();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_setReflection_Click(object sender, EventArgs e)
        {

            textBox4.Text = String.Empty;
            textBox4.Text += "Methods of class Star :" + Environment.NewLine;

            foreach (MethodInfo m in typeof(Star).GetMethods())
            {
                textBox4.Text += m.ToString() + Environment.NewLine;
            }

            textBox4.Text += Environment.NewLine + "Members of class Star :" + Environment.NewLine;

            foreach (MemberInfo m in typeof(Star).GetMembers())
            {
                textBox4.Text += m.ToString() + Environment.NewLine;
            }
        }

        private void button_draw_Click_1(object sender, EventArgs e)
        {
            new Star().Draw(ref pictureBox2);
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                star = new Star(
                    Convert.ToInt32(textBox1.Text),
                    Convert.ToInt32(textBox2.Text)
                );
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}