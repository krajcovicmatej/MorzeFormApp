using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MorzeFormApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.Show();
			Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form3 f3 = new Form3();
			f3.Show();
			Visible = false;
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged_1(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile1 = new OpenFileDialog();
			openFile1.Title = "Archív kódovania";
			openFile1.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MorseCodeArchive");
			openFile1.Filter = "Text|*.txt|All|*.*";
			openFile1.FilterIndex = 0;
			openFile1.ShowDialog();
		}

		private void button5_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFile1 = new OpenFileDialog();
			openFile1.Title = "Archív kódovania";
			openFile1.InitialDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MorseDecodeArchive");
			openFile1.Filter = "Text|*.txt|All|*.*";
			openFile1.FilterIndex = 0;
			openFile1.ShowDialog();
		}
	}
}
