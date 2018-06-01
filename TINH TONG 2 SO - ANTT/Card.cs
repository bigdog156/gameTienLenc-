using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TINH_TONG_2_SO___ANTT
{
    class Card
    {
        int gt;
        int chat;
        public Card()
        {

        }
        public Card(int gt, int chat) //constructer
        {
            this.gt = gt;
            this.chat = chat;
        }
        public int GetGt() //getter setter
        {
            return this.gt;
        }
        public int GetChat()
        {
            return chat;
        }
        public Card input(string str) //convert str -> card
        {
            int chat = int.Parse(str.Substring(str.Length - 1));
            int gt = int.Parse(str.Substring(0, str.Length - 1));
            Card card = new Card(gt, chat);
            return card;
        }
        public string GetID(Card c) //getID 1 la bai
        {
            string temp = c.GetGt().ToString() + c.GetChat().ToString();
            return temp;
        }

    }
    class CardSet
    {
        private Card[] set = new Card[52];

        public Card GetCard(int i)
        {
            return set[i];
        }
        public void SetCard(int i, Card gt)
        {
            set[i] = gt;
        }
        public string output(Card c) //convert card -> str (nhieu la bai)
        {
            string temp = c.GetGt().ToString() + c.GetChat().ToString() + "_";
            return temp;
        }

       

        public CardSet()
        {
            set[0] = new Card(3, 1);
            set[1] = new Card(3, 2);
            set[2] = new Card(3, 3);
            set[3] = new Card(3, 4);

            set[4] = new Card(4, 1);
            set[5] = new Card(4, 2);
            set[6] = new Card(4, 3);
            set[7] = new Card(4, 4);

            set[8] = new Card(5, 1);
            set[9] = new Card(5, 2);
            set[10] = new Card(5, 3);
            set[11] = new Card(5, 4);

            set[12] = new Card(6, 1);
            set[13] = new Card(6, 2);
            set[14] = new Card(6, 3);
            set[15] = new Card(6, 4);

            set[16] = new Card(7, 1);
            set[17] = new Card(7, 2);
            set[18] = new Card(7, 3);
            set[19] = new Card(7, 4);

            set[20] = new Card(8, 1);
            set[21] = new Card(8, 2);
            set[22] = new Card(8, 3);
            set[23] = new Card(8, 4);

            set[24] = new Card(9, 1);
            set[25] = new Card(9, 2);
            set[26] = new Card(9, 3);
            set[27] = new Card(9, 4);

            set[28] = new Card(10, 1);
            set[29] = new Card(10, 2);
            set[30] = new Card(10, 3);
            set[31] = new Card(10, 4);

            set[32] = new Card(11, 1);
            set[33] = new Card(11, 2);
            set[34] = new Card(11, 3);
            set[35] = new Card(11, 4);

            set[36] = new Card(12, 1);
            set[37] = new Card(12, 2);
            set[38] = new Card(12, 3);
            set[39] = new Card(12, 4);

            set[40] = new Card(13, 1);
            set[41] = new Card(13, 2);
            set[42] = new Card(13, 3);
            set[43] = new Card(13, 4);

            set[44] = new Card(14, 1);
            set[45] = new Card(14, 2);
            set[46] = new Card(14, 3);
            set[47] = new Card(14, 4);

            set[48] = new Card(15, 1);
            set[49] = new Card(15, 2);
            set[50] = new Card(15, 3);
            set[51] = new Card(15, 4);
        }
    }
}
