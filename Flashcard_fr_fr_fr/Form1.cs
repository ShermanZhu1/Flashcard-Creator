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

namespace Flashcard_fr_fr_fr
{
    public partial class Form1 : Form
    {
        List<Deck> decks;
        string[] decknames;
        int currcardnum = 0;
        Deck currdeck;

        public Form1()
        {
            InitDecks();
            InitializeComponent();
        }

        private void Flip_Click(object sender, EventArgs e)
        {
            if (cardText.Text == "")
            {
                return;
            } else if (cardText.Text[0] == 'Q')
            {
                cardText.Text = currdeck.GetFlashcard(currcardnum).getAnswer();
            } else if (cardText.Text[0] == 'A')
            {
                cardText.Text = currdeck.GetFlashcard(currcardnum).getQuestion();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currcardnum == 0)
            {
                return;
            }
            if (currcardnum == currdeck.getSize())
            {
                return;
            }
            cardText.Text = currdeck.GetFlashcard(currcardnum + 1).getQuestion();
            currcardnum++;
            Update_CardNum();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (currcardnum <= 1)
            {
                return;
            }
            cardText.Text = currdeck.GetFlashcard(currcardnum - 1).getQuestion();
            currcardnum--;
            Update_CardNum();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Update_CardNum()
        {
            this.cardNum.Text = currcardnum + "/" + currdeck.getSize();
        }

        private void Decks_Box(object sender, EventArgs e)
        {
            String deckname = (String)deckBox.SelectedItem;
            foreach (Deck d in decks) {
                if (d.getName() == deckname)
                {
                    currdeck = d;
                    currcardnum = 1;
                    cardText.Text = currdeck.GetFlashcard(currcardnum).getQuestion();
                    Update_CardNum();
                }
            }
        }

        private void InitDecks()
        {
            decks = new List<Deck>();
            string[] decknames = Directory.GetFiles("C:\\Users\\whent\\source\\repos\\Flashcard_fr_fr_fr\\Decks\\");
            string[] newdecknames = new string[decknames.Length];
            for (int i = 0; i < decknames.Length; i++)
            {
                string deckname = decknames[i].Remove(0, 53);
                string deckname2 = deckname.Remove(deckname.Length - 4);
                newdecknames[i] = deckname2;
                Deck deck = new Deck(deckname2, decknames[i]);
                decks.Add(deck);
            }
            this.decknames = newdecknames;
        }

        public string[] getDecknames()
        {
            return decknames;
        }
    }
}
