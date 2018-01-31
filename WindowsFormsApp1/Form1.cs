using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Dictionary<string, double> prefixes = new Dictionary<string, double>()
        {
            {"nm", 1e-9 },
            {"um", 1e-6 },
            {"mm", 1e-3 },
            {"cm", 1e-2 },
            {"m", 1 },
            {"km", 1e3 },
            {"Mm", 1e6 },
            {"Gm", 1e9 },
        };
        public Form1()
        {
            InitializeComponent();
            foreach (string k in prefixes.Keys)
            {
                comboBox3.Items.Add(k);
                comboBox4.Items.Add(k);
            }
            comboBox3.SelectedIndex = 4;
            comboBox4.SelectedIndex = 4;
            base.Update();
        }

        void update()
        {
            try
            {
                double d = double.Parse(richTextBox2.Text);
                double d2 = d * prefixes[comboBox3.Text] / prefixes[comboBox4.Text];
                label2.Text = d2.ToString();
            }
            catch
            {
                label2.Text = "";
            }
        }
        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            update();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
    }
}





