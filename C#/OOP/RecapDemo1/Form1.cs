using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Button[,] button = new Button[8,8];
            int top=0, left=0;
            for(int i = 0; i < button.GetUpperBound(0); i++)
            {
                for(int j = 0; j < button.GetUpperBound(1); j++)
                {
                    button[i, j] = new Button();
                    button[i, j].Width = 50;
                    button[i, j].Height = 50;
                    button[i, j].Left = left;
                    button[i, j].Top = top;
                    left += 50;
                    this.Controls.Add(button[i, j]);
                }
                top += 50;
                left = 0;
            }
            
        }
    }
}
