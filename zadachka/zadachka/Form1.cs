using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadachka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                char bukva = txtIme.Text.Trim().ToLower()[0];
                string egn = txtEGN.Text;
                lblIzhod.Text = $"{txtIme.Text} {txtEGN.Text}";
                MessageBox.Show($"{bukva},{egn[6]},{egn[7]}", "ime");

                int position = 1;             
                for (char b = 'a'; b < 'z'; b++)
                {
                    if (b == bukva)
                    {
                        break;
                    }
                    else { position++; }                   
                }
                if (position == egn[6] - '0'+ egn[7] - '0')
                {
                    MessageBox.Show("suvpadat");
                }
                else
                {
                    MessageBox.Show("ne suvpadat");
                }
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Greshka");
            }
                  
        }
    }
}
