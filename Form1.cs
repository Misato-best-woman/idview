using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdView
{
    public partial class Form1 : Form
    {
        string description = "Lorem impsum dolor sit amet ";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            descriptBox.Text = string.Concat(Enumerable.Repeat(description, 8));
            categoryName.Text = description;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (descriptBox.Text.Length != 1)
            {
                descriptBox.Text = descriptBox.Text.Substring(0, descriptBox.Text.Length / 2);
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            descriptBox.Text = string.Concat(Enumerable.Repeat(descriptBox.Text, 2));
        }
    }
}
