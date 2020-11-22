using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Spielfeld : Form
    {
        public Spielfeld()
        {
            InitializeComponent();
        }

		public int Spieler = 1;

		public int Runde = 0;

		public string[] FeldValue = new string[9];

		private void button1_Click(object sender, EventArgs e)
        {
			if (button1.Text == "")
			{
				int btn = 0;
				int Spielerneu = Spielzug(button1, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (button2.Text == "")
			{
				int btn = 1;
				int Spielerneu = Spielzug(button2, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (button3.Text == "")
			{
				int btn = 2;
				int Spielerneu = Spielzug(button3, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (button4.Text == "")
			{
				int btn = 3;
				int Spielerneu = Spielzug(button4, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (button5.Text == "")
			{
				int btn = 4;
				int Spielerneu = Spielzug(button5, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (button6.Text == "")
			{
				int btn = 5;
				int Spielerneu = Spielzug(button6, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (button7.Text == "")
			{
				int btn = 6;
				int Spielerneu = Spielzug(button7, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (button8.Text == "")
			{
				int btn = 7;
				int Spielerneu = Spielzug(button8, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();
					}
					else
					{
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}
				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (button9.Text == "")
			{
				int btn = 8;
				int Spielerneu = Spielzug(button9, btn);
				int Winner = WhoWonCheck.Check(Spieler, FeldValue);
				if (Winner != 0)
				{
					DialogResult result = MessageBox.Show("Glückwunsch! Spieler " + Winner + " hat gewonnen! Nochmal spielen?", "Du hast gewonnen!", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						this.Close();					
					}
                    else
                    {
						button1.Text = "";
						button2.Text = "";
						button3.Text = "";
						button4.Text = "";
						button5.Text = "";
						button6.Text = "";
						button7.Text = "";
						button8.Text = "";
						button9.Text = "";
						Array.Clear(FeldValue, 0, FeldValue.Length);
						Spieler = Spielerneu;
						txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
					}

				}
				else
				{
					Spieler = Spielerneu;
					txtB_aktSpieler.Text = "Spieler " + Spieler + " ist am Zug.";
				}
			}
			else
			{
				MessageBox.Show("Feld ist schon belegt! Wähle ein anderes Feld.");
			}
		}

		private int Spielzug(Button button, int btn)
		{
			int Spielerneu;
			if (Spieler == 1)
			{
				button.Text = "X";
				Spielerneu = 2;
				Runde++;
				FeldValue[btn] = "X";
			}
			else
			{
				button.Text = "O";
				Spielerneu = 1;
				Runde++;
				FeldValue[btn] = "O";
			}
			return Spielerneu;
		}

    }
}
