using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Win.ArrayJagged
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[][] MyArr = new int[][]
            {
                new int[] {1,3,5,7,9},
                new int[] {0,2,4,6},
                new int[] {11,22}
            };
            int rows = MyArr.Length;
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                result += $"Array[" + i + "] : [";
                for (int j = 0; j < MyArr[i].Length; j++)
                {
                    if (j == MyArr[i].Length - 1)
                        result += MyArr[i][j];
                    else
                        result += MyArr[i][j] + ",";
                    sum += MyArr[i][j];
                }
                result += "]" + Environment.NewLine;
                result += $"ผลรวมของแถวนี้ = {sum}" + Environment.NewLine + "---end---\r\n" + Environment.NewLine;
            }
            textBox2.Text = result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
