using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTPM_code
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int kq = 0;
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			Caculator c = new Caculator(a,b);
			kq = c.Exectute("+");
			label4.Text = kq.ToString();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			int kq = 0;
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			Caculator c = new Caculator(a, b);
			kq = c.Exectute("-");
			label4.Text = kq.ToString();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int kq = 0;
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			Caculator c = new Caculator(a, b);
			kq = c.Exectute("*");
			label4.Text = kq.ToString();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			int kq = 0;
			int a = int.Parse(textBox1.Text);
			int b = int.Parse(textBox2.Text);
			Caculator c = new Caculator(a, b);
			kq = c.Exectute("/");
			label4.Text = kq.ToString();
		}
	}
}
