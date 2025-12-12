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
            lblAverage.Text = "ค่าเฉลี่ย: " + average.ToString("F2");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string[,] data = new string[5, 3]
            {
                { "Alice", "แอลิซ", "กรุงเทพ" },
                { "Bob", "บ็อบ", "เชียงใหม่" },
                { "Charlie", "ชาร์ลี", "ภูเก็ต" },
                { "Diana", "ไดอาน่า", "ขอนแก่น" },
                { "Ethan", "อีธาน", "ชลบุรี" }
            };
            int rows = data.GetLength(0);
            int cols = data.GetLength(1);
            string Result = "";
            for (int i = 0; i < rows; i++)
            {
                Result += "ข้อมูลที่" + (i + 1) + ": ";
                Result += "ชื่อจริง : " + data[i, 0] + ", ";
                Result += "ชื่อเล่น : " + data[i, 1] + ", ";
                Result += "จังหวัด : " + data[i, 2] + Environment.NewLine;
            }
            textBox2.Text = Result;
        }
    }
}

