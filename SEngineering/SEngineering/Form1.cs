using System;
using System.Drawing;
using System.Windows.Forms;

namespace SEngineering
{
	public partial class Form1 : Form
	{
		public Form1()
		{


			InitializeComponent();
			// для первого блока
			// радио баттон 1 равно тру
			radioButton1.Checked = true;
			// радио баттон 4 равно тру
			radioButton4.Checked = true;
			// для второго блока
			radioButton013.Checked = true;
			radioButton023.Checked = true;
			radioButton033.Checked = true;
			//
			radioButton043.Checked = true;
			radioButton053.Checked = true;
			radioButton063.Checked = true;
			radioButton073.Checked = true;
			//
			radioButton083.Checked = true;
			radioButton093.Checked = true;
			radioButton103.Checked = true;
			radioButton113.Checked = true;
			radioButton123.Checked = true;
			//
			radioButton133.Checked = true;
			radioButton143.Checked = true;
			radioButton153.Checked = true;
			// для третьего блока
			radioButton163.Checked = true;
			radioButton173.Checked = true;
			radioButton183.Checked = true;
			radioButton193.Checked = true;
			radioButton203.Checked = true;
			radioButton214.Checked = true;
			radioButton224.Checked = true;
			radioButton234.Checked = true;
			radioButton244.Checked = true;
			radioButton254.Checked = true;
			radioButton264.Checked = true;
			radioButton274.Checked = true;
			radioButton283.Checked = true;
			radioButton293.Checked = true;
			radioButton303.Checked = true;
			radioButton313.Checked = true;
			radioButton323.Checked = true;
			radioButton333.Checked = true;
			radioButton343.Checked = true;
			radioButton353.Checked = true;
			radioButton363.Checked = true;
			radioButton373.Checked = true;
			radioButton383.Checked = true;
			radioButton393.Checked = true;
			radioButton403.Checked = true;
			radioButton413.Checked = true;
			radioButton423.Checked = true;
			radioButton433.Checked = true;
			radioButton443.Checked = true;

		}

		private void COCOMO_B_Load(object sender, EventArgs e)
		{
			dataGridView1.Rows.Add(3);
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.Rows[0].Cells[0].Value = "Распространенный";
			dataGridView1.Rows[0].Cells[1].Value = "2,4";
			dataGridView1.Rows[0].Cells[2].Value = "1,05";
			dataGridView1.Rows[0].Cells[3].Value = "2,5";
			dataGridView1.Rows[0].Cells[4].Value = "0,38";
			dataGridView1.Rows[1].Cells[0].Value = "Полунезависимый";
			dataGridView1.Rows[1].Cells[1].Value = "3,0";
			dataGridView1.Rows[1].Cells[2].Value = "1,12";
			dataGridView1.Rows[1].Cells[3].Value = "2,5";
			dataGridView1.Rows[1].Cells[4].Value = "0,35";
			dataGridView1.Rows[2].Cells[0].Value = "Встроенный";
			dataGridView1.Rows[2].Cells[1].Value = "3,6";
			dataGridView1.Rows[2].Cells[2].Value = "1,2";
			dataGridView1.Rows[2].Cells[3].Value = "2,5";
			dataGridView1.Rows[2].Cells[4].Value = "0,32";

		}

		private void COCOMO_I_Load(object sender, EventArgs e)
		{
			dataGridView2.Rows.Add(3);
			dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView2.Rows[0].Cells[0].Value = "Распространенный";
			dataGridView2.Rows[0].Cells[1].Value = "3,2";
			dataGridView2.Rows[0].Cells[2].Value = "1,05";
			dataGridView2.Rows[1].Cells[0].Value = "Полунезависимый";
			dataGridView2.Rows[1].Cells[1].Value = "3,0";
			dataGridView2.Rows[1].Cells[2].Value = "1,12";
			dataGridView2.Rows[2].Cells[0].Value = "Встроенный";
			dataGridView2.Rows[2].Cells[1].Value = "2,8";
			dataGridView2.Rows[2].Cells[2].Value = "1,2";

			dataGridView1.Rows.Add(3);
			dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView1.Rows[0].Cells[0].Value = "Распространенный";
			dataGridView1.Rows[0].Cells[1].Value = "2,4";
			dataGridView1.Rows[0].Cells[2].Value = "1,05";
			dataGridView1.Rows[0].Cells[3].Value = "2,5";
			dataGridView1.Rows[0].Cells[4].Value = "0,38";
			dataGridView1.Rows[1].Cells[0].Value = "Полунезависимый";
			dataGridView1.Rows[1].Cells[1].Value = "3,0";
			dataGridView1.Rows[1].Cells[2].Value = "1,12";
			dataGridView1.Rows[1].Cells[3].Value = "2,5";
			dataGridView1.Rows[1].Cells[4].Value = "0,35";
			dataGridView1.Rows[2].Cells[0].Value = "Встроенный";
			dataGridView1.Rows[2].Cells[1].Value = "3,6";
			dataGridView1.Rows[2].Cells[2].Value = "1,2";
			dataGridView1.Rows[2].Cells[3].Value = "2,5";
			dataGridView1.Rows[2].Cells[4].Value = "0,32";

			dataGridView3.Rows.Add(2);
			dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			dataGridView3.Rows[0].Cells[0].Value = "Предварительная";
			dataGridView3.Rows[0].Cells[1].Value = "2,94";
			dataGridView3.Rows[0].Cells[2].Value = "0,91";
			dataGridView3.Rows[0].Cells[3].Value = "3,67";
			dataGridView3.Rows[0].Cells[4].Value = "0,28";
			dataGridView3.Rows[1].Cells[0].Value = "Детальная";
			dataGridView3.Rows[1].Cells[1].Value = "2,45";
			dataGridView3.Rows[1].Cells[2].Value = "0,91";
			dataGridView3.Rows[1].Cells[3].Value = "3,67";
			dataGridView3.Rows[1].Cells[4].Value = "0,28";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			double PM = 0;
			double TM = 0;
			int currentRow1 = 0;

			if (radioButton1.Checked == true)
			{
				currentRow1 = 0;
			}
			else if (radioButton2.Checked == true)
			{
				currentRow1 = 1;
			}
			else if (radioButton3.Checked == true)
			{
				currentRow1 = 2;
			}

			int size = 0;

			if (maskedTextBox1.Text == "")
			{
				MessageBox.Show("Введите корректное значение количества строчек кода");
			}
			else
			{
				size = Convert.ToInt32(maskedTextBox1.Text);
			}




			double a = Convert.ToDouble(dataGridView1.Rows[currentRow1].Cells[1].Value);
			double b = Convert.ToDouble(dataGridView1.Rows[currentRow1].Cells[2].Value);
			double c = Convert.ToDouble(dataGridView1.Rows[currentRow1].Cells[3].Value);
			double d = Convert.ToDouble(dataGridView1.Rows[currentRow1].Cells[4].Value);

			PM = Math.Pow(size, b) * a;
			TM = Math.Pow(PM, d) * c;

			textBox1.Text = Convert.ToString(PM);
			textBox2.Text = Convert.ToString(TM);

		}

		private static double summing(double sum, double matrix, int i)
		{
			if (i == 0)
			{
				if (matrix == 0)
				{
					return sum;
				}
				else
				{
					return sum + matrix;
				}
			} else
			{
				if (matrix == 0)
				{
					return sum;
				}
				else
				{
					return sum * matrix;
				}
			}
			
		}

		private static double delling(double sum, double matrix)
		{
			if (matrix == 0)
			{
				return sum;
			}
			else
			{
				return (sum / matrix);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			double PM = 0;
			double TM = 0;
			int currentRow1 = 0;

			int size = 0;

			if (maskedTextBox1.Text == "")
			{
				MessageBox.Show("Введите корректное значение количества строчек кода");
			}
			else
			{
				size = Convert.ToInt32(maskedTextBox1.Text);
			}

			if (radioButton1.Checked == true)
			{
				currentRow1 = 0;
			}
			else if (radioButton2.Checked == true)
			{
				currentRow1 = 1;
			}
			else if (radioButton3.Checked == true)
			{
				currentRow1 = 2;
			}

			double[,] СD = new double[3, 2] {
				{2.50, 0.38},
				{2.50, 0.35},
				{2.50, 0.32}
			};

			double a = Convert.ToDouble(dataGridView2.Rows[currentRow1].Cells[1].Value);
			double b = Convert.ToDouble(dataGridView2.Rows[currentRow1].Cells[2].Value);
			double c = СD[currentRow1, 0];
			double d = СD[currentRow1, 1];

			double[,] matrix = new double[15, 6] {
				{0.75, 0.88, 1.00, 1.15, 1.40, 0.00},
				{0.00, 0.94, 1.00, 1.08, 1.16, 0.00},
				{0.70, 0.85, 1.00, 1.15, 1.30, 1.65},
				{0.00, 0.00, 1.00, 1.11, 1.30, 1.66},
				{0.00, 0.00, 1.00, 1.06, 1.21, 1.56},
				{0.00, 0.87, 1.00, 1.15, 1.30, 0.00},
				{0.00, 0.87, 1.00, 1.07, 1.15, 0.00},
				{1.46, 1.19, 1.00, 0.86, 0.71, 0.00},
				{1.29, 1.13, 1.00, 0.91, 0.82, 0.00},
				{1.42, 1.17, 1.00, 0.86, 0.70, 0.00},
				{1.21, 1.10, 1.00, 0.90, 0.00, 0.00},
				{1.14, 1.07, 1.00, 0.95, 0.00, 0.00},
				{1.24, 1.10, 1.00, 0.91, 0.82, 0.00},
				{1.24, 1.10, 1.00, 0.91, 0.83, 0.00},
				{1.23, 1.08, 1.00, 1.04, 1.10, 0.00}
			};


			double sum = 1;

			foreach (Control groupBox1 in this.tabControl1.TabPages[1].Controls)
			{
				GroupBox currentGroupBox1 = groupBox1 as GroupBox;
				if (currentGroupBox1 != null)
				{
					foreach (Control groupBox2 in currentGroupBox1.Controls)
					{
						GroupBox currentGroupBox2 = groupBox2 as GroupBox;
						if (currentGroupBox2 != null)
						{
							foreach (Control control in currentGroupBox2.Controls)
							{
								RadioButton radioButton = control as RadioButton;
								if (radioButton != null)
								{
									if (radioButton.Checked)
									{
										sum = summing(sum, matrix[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 1, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1], 1);
									}
								}
							}
						}
					}
				}
			}

			PM = Math.Pow(size, b) * sum * a;
			TM = Math.Pow(PM, d) * c;

			textBox4.Text = Convert.ToString(PM);
			textBox3.Text = Convert.ToString(TM);

		}

		private void radioButton9_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void label22_Click(object sender, EventArgs e)
		{

		}

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void label45_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{
			double PM = 0;
			double TM = 0;
			int currentRow1 = 0;

			int size = 0;

			if (maskedTextBox1.Text == "")
			{
				MessageBox.Show("Введите корректное значение количества строчек кода");
			}
			else
			{
				size = Convert.ToInt32(maskedTextBox1.Text);
			}

			if (radioButton4.Checked == true)
			{
				currentRow1 = 0;
			}
			else if (radioButton5.Checked == true)
			{
				currentRow1 = 1;
			}

			double[,] SF = new double[5, 6] {
				{6.20, 4.96, 3.72, 2.48, 1.24, 0.00},
				{5.07, 4.05, 3.04, 2.03, 1.01, 0.00},
				{7.07, 5.65, 4.24, 2.83, 1.41, 0.00},
				{5.48, 4.38, 3.29, 2.19, 1.10, 0.00},
				{7.80, 6.24, 4.68, 3.12, 1.56, 0.00}
			};

			double[,] EM = new double[7, 7] {
				{2.12, 1.62, 1.26, 1.00, 0.83, 0.63, 0.50},
				{1.59, 1.33, 1.22, 1.00, 0.87, 0.74, 0.62},
				{0.49, 0.60, 0.83, 1.00, 1.33, 1.91, 2.72},
				{0.00, 0.00, 0.95, 1.00, 1.07, 1.15, 1.24},
				{0.00, 0.00, 0.87, 1.00, 1.29, 1.81, 2.61},
				{1.43, 1.30, 1.10, 1.00, 0.87, 0.73, 0.62},
				{1.00, 1.43, 1.14, 1.00, 1.00, 1.00, 1.00}
			};

			double[,] PA = new double[17, 6] {
				{1.42, 1.29, 1.00, 0.85, 0.71, 0.00},
				{1.22, 1.10, 1.00, 0.88, 0.81, 0.00},
				{1.34, 1.15, 1.00, 0.88, 0.76, 0.00},
				{1.29, 1.12, 1.00, 0.90, 0.81, 0.00},
				{1.19, 1.09, 1.00, 0.91, 0.85, 0.00},
				{1.20, 1.09, 1.00, 0.91, 0.84, 0.00},
				{0.84, 0.92, 1.00, 1.10, 1.26, 0.00},
				{0.00, 0.23, 1.00, 1.14, 1.26, 0.00},
				{0.73, 0.87, 1.00, 1.17, 1.34, 1.74},
				{0.00, 0.95, 1.00, 1.07, 1.15, 1.24},
				{0.81, 0.91, 1.00, 1.11, 1.23, 0.00},
				{0.00, 0.00, 1.00, 1.11, 1.29, 1.63},
				{0.00, 0.00, 1.00, 1.05, 1.17, 1.46},
				{0.00, 0.87, 1.00, 1.15, 1.30, 0.00},
				{1.17, 1.09, 1.00, 0.90, 0.78, 0.00},
				{1.22, 1.09, 1.00, 0.93, 0.86, 0.80},
				{1.43, 1.14, 1.00, 1.00, 1.00, 1.00}
			};

			double a = Convert.ToDouble(dataGridView3.Rows[currentRow1].Cells[1].Value);
			double b = Convert.ToDouble(dataGridView3.Rows[currentRow1].Cells[2].Value);
			double c = Convert.ToDouble(dataGridView3.Rows[currentRow1].Cells[3].Value);
			double d = Convert.ToDouble(dataGridView3.Rows[currentRow1].Cells[4].Value);

			double sum = 1;

			//факторы масштаба
			foreach (Control groupBox1 in this.tabControl1.TabPages[2].Controls)
			{
				GroupBox currentGroupBox1 = groupBox1 as GroupBox;
				if (currentGroupBox1 != null)
				{
					foreach (Control groupBox2 in currentGroupBox1.Controls)
					{
						GroupBox currentGroupBox2 = groupBox2 as GroupBox;
						if (currentGroupBox2 != null)
						{
							foreach (Control control in currentGroupBox2.Controls)
							{
								RadioButton radioButton = control as RadioButton;
								if (radioButton != null)
								{
									if (radioButton.Checked)
									{
										sum = summing(sum, SF[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 16, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1], 0);
									}
								}
							}
						}
					}
				}
			}

			double E = b + 0.01 * sum;
			double SCED = 0;
			sum = 1;

			//факторы масштаба
			foreach (Control groupBox1 in this.tabControl2.TabPages[currentRow1].Controls)
			{
				GroupBox currentGroupBox1 = groupBox1 as GroupBox;
				if (currentGroupBox1 != null)
				{
					foreach (Control groupBox2 in currentGroupBox1.Controls)
					{
						GroupBox currentGroupBox2 = groupBox2 as GroupBox;
						if (currentGroupBox2 != null)
						{
							foreach (Control control in currentGroupBox2.Controls)
							{
								RadioButton radioButton = control as RadioButton;
								if (radioButton != null)
								{
									if (radioButton.Checked)
									{
										if (currentRow1 == 0)
										{
											if ((Convert.ToInt32((radioButton.Name.Substring(11, 2))) >= 21) && (Convert.ToInt32((radioButton.Name.Substring(11, 2))) <= 27))
											{
												sum = summing(sum, EM[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 21, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1], 1);
												if (Convert.ToInt32((radioButton.Name.Substring(11, 2))) == 27)
												{
													SCED = EM[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 21, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1];
												}
											}
										}
										else
										{
											if ((Convert.ToInt32((radioButton.Name.Substring(11, 2))) >= 28))
											{
												sum = summing(sum, PA[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 28, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1], 1);
												if (Convert.ToInt32((radioButton.Name.Substring(11, 2))) == 44)
												{
													SCED = PA[Convert.ToInt32(radioButton.Name.Substring(11, 2)) - 28, Convert.ToInt32(radioButton.Name.Substring(13, 1)) - 1];
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}

			PM = sum * a * Math.Pow(size, E);

			textBox6.Text = Convert.ToString(PM);

			double x = delling(size, SCED);

			PM = sum * a * Math.Pow(x, E);

			TM = SCED * c * Math.Pow(PM, (d + 0.2 * (E - b)));

			textBox5.Text = Convert.ToString(TM);


		}

		private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{

		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
