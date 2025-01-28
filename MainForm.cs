using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace QuickQuiz
{
    public partial class MainForm : Form
    {
        Assembly myAssembly = Assembly.GetEntryAssembly();


        string local_dir = "";

        List<Quiz_data> Quizes = new List<Quiz_data>();
        int QuizIndex = 0; // 現在のクイズ番号
        int Max_QuizCount = 0;

        // フィールド
        public FormAnswer frm_FormAnswer; //子(FormAnswer)の参照先
        // 子(cf_calib)の状態
        public bool frm_FormAnswer_enable = false;

        public MainForm()
        {
            InitializeComponent();

#if DEBUG
            local_dir = "c:\\local";
#else
            local_dir = Path.GetDirectoryName(myAssembly.Location);
#endif

            Init();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        void Init()
        {
            string data_fullpath = local_dir + Path.DirectorySeparatorChar + "quiz_data.csv";

            if (File.Exists(data_fullpath) == false)
            {
                textBox_Question.Text = data_fullpath;
            }
            else
            {
                load_csvdata(data_fullpath);

                ShuffleUtils.Shuffle(Quizes);

                //問題を画面表示
                load_question();
            }

#if DEBUG
            foreach (Quiz_data data in Quizes)
            {
                string debug = data.printout();
                Debug.WriteLine(debug);
            }
#endif
        }

        public void increment_quiz_index()
        {
            //インデックスを増加
            QuizIndex++;
            if (Max_QuizCount > QuizIndex)
            {
                //OK 新しい問題にアップデート
                ; ;
            }
            else
            {
                //NG 全問終了
                QuizIndex = 0;
                ShuffleUtils.Shuffle(Quizes);
            }

            //問題を画面表示
            load_question();
        }

        void load_question()
        {
            labelCategory.Text = Quizes[QuizIndex].Category + " [Lv." + Quizes[QuizIndex].Level.ToString() + "]";
            textBox_Question.Text = Quizes[QuizIndex].Question;

            textBox_Option1.Text = Quizes[QuizIndex].Answer[0];
            textBox_Option2.Text = Quizes[QuizIndex].Answer[1];
        }

        int load_csvdata(string filename)
        {
            Random rnd = new Random();

            List<List<string>> data_csv = new List<List<string>>();

            if (File.Exists(filename))
            {
                CsvReader dat = new CsvReader(filename, Encoding.GetEncoding(932) /*"Shift_JIS"*/);

                data_csv = dat.ReadToEnd();
            }

            Max_QuizCount = data_csv.Count;

            for (int i = 1; i < Max_QuizCount; i++)
            {
                //正答番号 0 or 1
                int no_collect = rnd.Next(0, 2);
                int no_wrong = -1;
                if (no_collect == 1) { no_wrong = 0; }
                else { no_wrong = 1; }

                //data_csv カテゴリ	難易度	問題	正答	誤答	解説
                //Quiz_data(string category, int level, string question, string[] answer, int no_collect, string description)

                string[] answer = new string[2];
                answer[no_collect] = data_csv[i][3];
                answer[no_wrong] = data_csv[i][4];

                Quizes.Add(new Quiz_data(data_csv[i][0], Convert.ToInt32(data_csv[i][1]), data_csv[i][2], answer, no_collect, data_csv[i][5]));
            }

            return Max_QuizCount;
        }

        private void button_answer_Click(object sender, EventArgs e)
        {
            if (frm_FormAnswer_enable == false)
            {
                // Form(cf_calib)のインスタンス生成
                FormAnswer frm_answer0 = new FormAnswer((Quizes[QuizIndex].NoCollect + 1).ToString(), Quizes[QuizIndex].Answer[Quizes[QuizIndex].NoCollect], Quizes[QuizIndex].Description);

                // ステータスをenableにする
                frm_FormAnswer_enable = true;

                // 子を参照
                frm_FormAnswer = frm_answer0;

                // 子から参照可
                frm_answer0.frm_main = this;

                //// 所有権はメイン
                this.AddOwnedForm(frm_answer0);

                //// open config_camera
                frm_answer0.Show();
            }
        }
    }
}
