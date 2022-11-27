using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Board
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			Button[,] buttons = new Button[8,8];                     // 8*8  array button
			int top = 0;
			int left = 0;
			for (int i = 0; i < buttons.GetUpperBound(0); i++)		// ROW 
			{
				for (int j = 0; j < buttons.GetUpperBound(1); j++)  //Colom
				{
					buttons[i, j] = new Button();
					buttons[i, j].Width = 50;
					buttons[i, j].Height = 50;
					buttons[i, j].Top = top;
					buttons[i, j].Left = left;   
					left += 50;                 //İlk buttonu sola koydu Sonra aralara 50 boşluk

					if((i+j)%2 == 0)
					{
						buttons[i, j].BackColor = Color.Black;
					}
					else
					{
						buttons[i, j].BackColor = Color.White;
					}
					
					this.Controls.Add(buttons[i,j]);  // Show button on the screen
				}
				left = 0;                    //Satır bittiğinde sıfırla
				top += 50;					// Satır bitince toptan 50 boşluk

			}
			


		}
	}
}
