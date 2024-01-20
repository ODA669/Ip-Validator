using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipvalidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Console.WriteLine(DateTime.Now.ToString());
        }
        private bool ValidIP(string ipaddress)
        {
            Regex regex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$");
            return regex.IsMatch(ipaddress);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime meetingAppt = new DateTime(2008, 9, 22);
            System.Console.WriteLine(meetingAppt.ToString());

            string ipaddress = textBox1.Text;
            bool check = false;

            check = ValidIP(ipaddress);
            //MessageBox.Show(check.ToString());
            if (check == true)
            {
                MessageBox.Show(ipaddress + "\n The IP is correct.", "Valid IP");
            }
            else
            {
                MessageBox.Show("The IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot(255.255.255.255)");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(MessageBox.Show("EXIT", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            //MessageBox.Show(i.ToString());
            if (i == 1)
            {
                this.Close();
            }
            else
            {
                textBox1.Text = "";
                textBox1.Focus();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox1.Focus();

        }
    }
}
