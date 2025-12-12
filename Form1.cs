namespace WinFormsApp104Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            int[] numbers = new int[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                if (int.TryParse(data[i], out int number))
                {
                    numbers[i] = number;
                }
                else
                {
                    numbers[i] = 0;
                }
            }
            int sum = 0;
            int min = numbers.Length > 0 ? numbers[0] : 0;
            int max = numbers.Length > 0 ? numbers[0] : 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            double average = (double)sum / numbers.Length;

            lblCount.Text = "จำนวนสมาชิกข้อมูล: " + numbers.Length;
            lblSum.Text = "ผลรวม: " + sum;
            lblAverage.Text = "ค่าเฉลี่ย: " + average;
            lblMin.Text = "ค่าต่ำสุด: " + min;
            lblMax.Text = "ค่าสูงสุด: " + max;
        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
