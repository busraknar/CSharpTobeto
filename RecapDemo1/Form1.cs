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
            //for (int i = 1; i <= 64; i   //bunda nesnelere erişemeyiz hepsi aynı olur.
            //{
            //    Button button = new Button();
            //    button.Width = 50;
            //    button.Height = 50;
            //    button.Text = "My button";
            //    this.Controls.Add(button); //butonu projeye ekler
            // }
            //--------------------------------------------------------
            int top = 0;
            int left = 0;
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i < buttons.GetUpperBound(0); i++) // inin alabileceği deger    //getUpperBond()   0.boyutun en büyük alabileceği değer
            {
                for (int j = 0; j < buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 50;
                    buttons[i, j].Height = 50;
                    buttons[i, j].Left = left;

                    buttons[i, j].Top = top;
                    left += 50;

                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }


                    this.Controls.Add(buttons[i, j]);
                }//ilk satır için top =0 yani  ilk sırada, ikinci sıra 50 karakter aşağıdan başlamalı
                top += 50;
                left = 0;
            }


        }
    }
}
