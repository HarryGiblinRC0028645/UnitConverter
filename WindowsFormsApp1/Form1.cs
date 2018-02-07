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

        Dictionary<string, double> areas = new Dictionary<string, double>()
        {
            {"nm²", 1e-18 },
            {"um²", 1e-12 },
            {"mm²", 1e-6 },
            {"cm²", 1e-4 },
            {"m²", 1 },
            {"km²", 1e6 },
            {"Mm²", 1e12 },
            {"Gm²", 1e18 },
        };

        Dictionary<string, double> volumes = new Dictionary<string, double>()
        {
            {"nm³", 1e-27 },
            {"um³", 1e-18 },
            {"mm³", 1e-9 },
            {"cm³", 1e-6 },
            {"m³", 1 },
            {"km³", 1e9 },
            {"Mm³", 1e18 },
            {"Gm³", 1e27 },
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
            foreach (string k in areas.Keys)
            {
                comboBox1.Items.Add(k);
                comboBox2.Items.Add(k);
            }
            comboBox1.SelectedIndex = 4;
            comboBox2.SelectedIndex = 4;
            base.Update();
            foreach (string k in volumes.Keys)
            {
                comboBox5.Items.Add(k);
                comboBox6.Items.Add(k);
            }
            comboBox5.SelectedIndex = 4;
            comboBox6.SelectedIndex = 4;
            base.Update();

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

                    double d3 = double.Parse(richTextBox2.Text);
                    double d4 = d3 * areas[comboBox1.Text] / areas[comboBox2.Text];
                    label1.Text = d4.ToString();

               

                    double d5 = double.Parse(richTextBox2.Text);
                    double d6 = d5 * volumes[comboBox5.Text] / volumes[comboBox6.Text];
                    label3.Text = d6.ToString();
      
                    label2.Text = "";
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

       
      

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





