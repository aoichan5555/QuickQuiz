using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace QuickQuiz
{
    public class Quiz_data
    {
        public Quiz_data(string category, int level, string question, string[] answer, int no_collect, string description)
        {
            Answer = new string[2];

            Category = category;
            Level = level;
            Question = question;
            Answer[0] = answer[0];
            Answer[1] = answer[1];
            NoCollect = no_collect;
            Description = description;
        }

        public string Category = "";
        public int Level;
        public string Question = "";
        public string[] Answer;
        public int NoCollect;
        public string Description = "";

        public string printout()
        {
            string ret = string.Empty;

            ret += "category=" + Category;
            ret += ",level=" + Level.ToString();
            ret += ",Q=" + Question;
            ret += ",Ans=0" + Answer[0];
            ret += ",Ans1=" + Answer[1];
            ret += ",no_collect=" + NoCollect.ToString();
            ret += ",desc=" + Description;

            return ret;
        }
    }

    public static class ShuffleUtils
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }


}
