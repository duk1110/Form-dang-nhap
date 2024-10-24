using System.DirectoryServices;
using System.Text.RegularExpressions;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;


            if(email == "admin" &&  password == "1234")
            {
                MessageBox.Show("Đăng nhập thành công.");
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại.");
            }
        }
    }
}
