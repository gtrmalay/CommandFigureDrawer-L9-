using LABA8;
using System.Windows.Forms;

namespace LABA99999
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics graphics;

        Pen pen = new Pen(Color.Black, 5);

        string CmdName = RPN.name;


        public Form1()
        {
            InitializeComponent();

            this.bitmap = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox1;
            Init.pen = this.pen;
        }



        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {


            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MessageBox.Show("dsds");

                    string InputCmd = textBoxInputString.Text;

                    RPN.CalculateRPN(textBoxInputString.Text);

                    if (ShapeContainer.IsSuccess)
                    {
                        Commands_ListBox.Items.Add(RPN.expressionstring + " - Выполнено успешно!");
                    }


                }

            }
            catch
            {
                Commands_ListBox.Items.Add(RPN.expressionstring + " - Не выполнено!");
            }

        }
    }
}