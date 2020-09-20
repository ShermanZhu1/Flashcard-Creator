using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Flashcard_fr_fr_fr
{
    class Deck
    {
        private List<TextFlashcard> flashcards;
        private String name;
        private int size;

        public Deck(String name, String direc)
        {
            flashcards = new List<TextFlashcard>();
            initDeck(direc);
            this.name = name;
        }

        private void initDeck(String direc)
        {
            string[] lines = File.ReadAllLines(direc);
            Boolean alt = false;
            String ques = "";
            String ans = "";
            int num = 1;
            size = 0;
            foreach (string line in lines)
            {
                if (alt)
                {
                    ans = line;
                    TextFlashcard card = new TextFlashcard(ques, ans, num);
                    flashcards.Add(card);
                    num++;
                    size++;
                } else
                {
                    ques = line;
                }
                alt = !alt;
            }
        }

        public int getSize()
        {
            return size;
        }

        public String getName()
        {
            return name;
        }

        public TextFlashcard GetFlashcard(int num)
        {
            foreach (TextFlashcard card in flashcards)
            {
                if (card.getNum() == num)
                {
                    return card;
                }
            }
            return new TextFlashcard("dummy", "bruh", 3);
        }
    }
}
