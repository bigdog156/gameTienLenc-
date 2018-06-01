/*
 * Created by SharpDevelop.
 * User: chepchip
 * Date: 4/18/2017
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TINH_TONG_2_SO___ANTT;

namespace CLIENT
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}

       

        private void button3_Click(object sender, EventArgs e)
        {
            TurnOffCardTop();
            for (int i = 0; i < cards.Length; i++)
            {
                for (int j = i + 1; j < cards.Length; j++)
                {
                    if (cards[j].GetGt() < cards[i].GetGt())
                    {
                        //cach trao doi gia tri
                        Card tmp = new Card();
                        tmp = cards[i];
                        cards[i] = cards[j];
                        cards[j] = tmp;
                    }
                }
            }
            pictureBox1.Image = DrawCard(cards[0]);
            pictureBox2.Image = DrawCard(cards[1]);
            pictureBox3.Image = DrawCard(cards[2]);
            pictureBox4.Image = DrawCard(cards[3]);
            pictureBox5.Image = DrawCard(cards[4]);
            pictureBox6.Image = DrawCard(cards[5]);
            pictureBox7.Image = DrawCard(cards[6]);
            pictureBox8.Image = DrawCard(cards[7]);
            pictureBox9.Image = DrawCard(cards[8]);
            pictureBox10.Image = DrawCard(cards[9]);
            pictureBox11.Image = DrawCard(cards[10]);
            pictureBox12.Image = DrawCard(cards[11]);
            pictureBox13.Image = DrawCard(cards[12]);
            TurnOnCardBot();
            ResetChooseCard(soBaiConLai);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = pictureBox12.Image;
            pictureBox15.Visible = true;
            pictureBox12.Visible = false;
            chooseCard[11] = cards[11];
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = pictureBox11.Image;
            pictureBox11.Visible = false;
            pictureBox16.Visible = true;
            chooseCard[10] = cards[10];
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = pictureBox10.Image;
            pictureBox10.Visible = false;
            pictureBox17.Visible = true;
            chooseCard[9] = cards[9];
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox18.Image = pictureBox9.Image;
            pictureBox9.Visible = false;
            pictureBox18.Visible = true;
            chooseCard[8] = cards[8];
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox19.Image = pictureBox8.Image;
            pictureBox8.Visible = false;
            pictureBox19.Visible = true;
            chooseCard[7] = cards[7];
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox20.Image = pictureBox7.Image;
            pictureBox7.Visible = false;
            pictureBox20.Visible = true;
            chooseCard[6] = cards[6];
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox22.Image = pictureBox5.Image;
            pictureBox5.Visible = false;
            pictureBox22.Visible = true;
            chooseCard[4] = cards[4];
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox21.Image = pictureBox6.Image;
            pictureBox6.Visible = false;
            pictureBox21.Visible = true;
            chooseCard[5] = cards[5];
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox23.Image = pictureBox4.Image;
            pictureBox4.Visible = false;
            pictureBox23.Visible = true;
            chooseCard[3] = cards[3];
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox24.Image = pictureBox3.Image;
            pictureBox3.Visible = false;
            pictureBox24.Visible = true;
            chooseCard[2] = cards[2];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox26.Image = pictureBox1.Image;
            pictureBox1.Visible = false;
            pictureBox26.Visible = true;
            chooseCard[0] = cards[0];
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = pictureBox13.Image;
            pictureBox13.Visible = false;
            pictureBox14.Visible = true;
            chooseCard[12] = cards[12];

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox25.Image = pictureBox2.Image;
            pictureBox2.Visible = false;
            pictureBox25.Visible = true;
            chooseCard[1] = cards[1];

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox13.Image = pictureBox14.Image;
            pictureBox14.Visible = false;
            pictureBox13.Visible = true;
            chooseCard[12] = null;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = pictureBox15.Image;
            pictureBox15.Visible = false;
            pictureBox12.Visible = true;
            chooseCard[11] = null;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = pictureBox16.Image;
            pictureBox16.Visible = false;
            pictureBox11.Visible = true;
            chooseCard[10] = null;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = pictureBox17.Image;
            pictureBox17.Visible = false;
            pictureBox10.Visible = true;
            chooseCard[9] = null;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = pictureBox18.Image;
            pictureBox18.Visible = false;
            pictureBox9.Visible = true;
            chooseCard[8] = null;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            pictureBox8.Image = pictureBox19.Image;
            pictureBox19.Visible = false;
            pictureBox8.Visible = true;
            chooseCard[7] = null;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = pictureBox20.Image;
            pictureBox20.Visible = false;
            pictureBox7.Visible = true;
            chooseCard[6] = null;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = pictureBox21.Image;
            pictureBox21.Visible = false;
            pictureBox6.Visible = true;
            chooseCard[5] = null;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = pictureBox22.Image;
            pictureBox22.Visible = false;
            pictureBox5.Visible = true;
            chooseCard[4] = null;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = pictureBox23.Image;
            pictureBox23.Visible = false;
            pictureBox4.Visible = true;
            chooseCard[3] = null;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox24.Image;
            pictureBox24.Visible = false;
            pictureBox3.Visible = true;
            chooseCard[2] = null;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox25.Image;
            pictureBox25.Visible = false;
            pictureBox2.Visible = true;
            chooseCard[1] = null;
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pictureBox26.Image;
            pictureBox26.Visible = false;
            pictureBox1.Visible = true;
            chooseCard[0] = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string data = null;
            foreach (Card item in chooseCard)
            {
                if(item != null)
                {
                    data += (item.GetID(item) + "_");
                }
                
            }
            baiDanh = data;
            tcp.SendData(baiDanh);

        }
    }
}
