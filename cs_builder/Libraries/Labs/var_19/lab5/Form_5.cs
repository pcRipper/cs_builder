using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace cs_builder.Libraries.Labs.var_19.lab5
{
    public partial class Form_5 : Form
    {
        static FileStream fs;
        private void set_status(string text)
        {

        }

        private bool check_file(string path)
        {

            if (path.Length == 0)
            {
                set_status("Wrong file path input!");
                return false;
            }

            FileInfo info = new FileInfo(path);

            if (!info.Exists)
            {
                set_status("File is missing");
                return false;
            }

            return true;
        }

        public Form_5()
        {
            InitializeComponent();
            button_draw_Click(null, null);
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file_pick = new OpenFileDialog();
            if (file_pick.ShowDialog() == DialogResult.OK)
            {
                textBox_path.Text = file_pick.FileName;
            }
        }

        XmlSerializer formatter_xml = new XmlSerializer(typeof(Star));
        BinaryFormatter formatter_binary = new BinaryFormatter();
        private static bool color = true;
        private UInt16 ticks = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (check_file(textBox_path.Text))
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    //formatter_binary.Serialize(fs, null);
                    set_status("Binary serialization success!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (check_file(textBox_path.Text))
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    //formatter_xml.Serialize(fs, puck_1);
                    set_status("XML serialization success!");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (check_file(textBox_path.Text))
            {

                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    //puck_1 = (Star)formatter_binary.Deserialize(fs);
                }

                //set_fields();
                set_status("Binary deserialization success!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (check_file(textBox_path.Text))
            {
                using (fs = new FileStream(textBox_path.Text, FileMode.Open))
                {
                    //puck_1 = (Star)formatter_xml.Deserialize(fs);
                }

                //set_fields();
                set_status("XML deserialization success!");
            }
        }

        private void button_setReflection_Click(object sender, EventArgs e)
        {
            string nl = Environment.NewLine;

            textBox4.Text = "";

            MethodInfo[] methods = typeof(Star).GetMethods();
            MemberInfo[] members = typeof(Star).GetMembers();

            textBox4.Text += "Methods of class Star :" + nl;

            foreach (MethodInfo m in methods)
            {
                textBox4.Text += m.ToString() + nl;
            }

            textBox4.Text += nl + "Members of class Star :" + nl;

            foreach (MemberInfo m in members)
            {
                textBox4.Text += m.ToString() + nl;
            }
        }

        private void button_draw_Click(object sender, EventArgs e)
        {

        }

        private void button_setArea_Click(object sender, EventArgs e)
        {

        }

        private void button_setA_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(textBox1.Text, out double a))
            {
                if (a > 0)
                {
                    //puck_1.A = a;
                    set_status("Values seted!");
                    //set_fields();
                }
                else
                {
                    set_status("Value can not be less than 0!");
                }
            }
            else
            {
                set_status("Wrong input!");
            }
        }
    }
}