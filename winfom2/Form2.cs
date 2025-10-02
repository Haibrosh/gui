using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace winfom2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b;
            if (float.TryParse(textBox1.Text, out a) && float.TryParse(textBox2.Text, out b))
            {
                float c = a + b;
                label1.Text = c.ToString(); // Ghi đè kết quả mới
            }
            else
            {
                label1.Text = "Vui lòng nhập số hợp lệ!";
            }
        }

    }
}
