using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{   //   EXTEND PREVIOUS TO CREATE A 2-D ARRAY OF BUTTONS (each with number on)
    public partial class Form1 : Form
    {
        string input = string.Empty;
        Button[,] btn = new Button[5, 5];       // Create 2D array of buttons
        public Form1()
        {
            InitializeComponent();
            for (int x = 0; x < btn.GetLength(0); x++)         // Loop for x
            {
                for (int y = 0; y < btn.GetLength(1); y++)     // Loop for y
                {
                    btn[x, y] = new Button();
                    btn[x, y].SetBounds(55 * x, 55 * y, 45, 45);
                    btn[x, y].BackColor = Color.PowderBlue;
                    btn[x, y].Text = Convert.ToString((x + 1) + "," + (y + 1));
                    btn[x, y].Click += new EventHandler(this.btnEvent_Click);
                    Controls.Add(btn[x, y]);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)  //REQUIRED
        {
        }
        void btnEvent_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            input += ((Button)sender).Text;
            this.textBox2.Text += input;
            Console.WriteLine(((Button)sender).Text);    // SAME handler as before
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}