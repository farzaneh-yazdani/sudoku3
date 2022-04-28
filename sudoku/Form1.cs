using System;
using System.IO;

namespace sudoku

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    TextBox m = new TextBox();
                    m.Multiline=true;
                    m.TextAlign = HorizontalAlignment.Center;
                    m.Font = new Font("Times New Roman", 16);
                    m.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                    tableLayoutPanel1.Controls.Add(m,i,j);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            if(x.ShowDialog() == DialogResult.OK)
            {
                string file_path = x.FileName;
                StreamReader my_file = new StreamReader(file_path);
                string big_text = my_file.ReadToEnd();
                MessageBox.Show(big_text);
                char[] my_seperators ={ ' ','\n'};
                string[] numbers = big_text.Split(my_seperators);




            }
        }
    }
}