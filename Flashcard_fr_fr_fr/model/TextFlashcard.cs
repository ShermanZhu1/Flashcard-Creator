using Flashcard_fr_fr_fr.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcard_fr_fr_fr
{
    class TextFlashcard
    {
        private String ques;
        private String ans;
        private int num;

        public TextFlashcard(string ques, string ans, int num)
        {
            this.ques = ques;
            this.ans = ans;
            this.num = num;
        }

        public String getQuestion()
        {
            return ques;
        }

        public String getAnswer()
        {
            return ans;
        }

        public int getNum()
        {
            return num;
        }
    }
}
