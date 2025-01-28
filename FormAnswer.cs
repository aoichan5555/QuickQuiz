using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickQuiz
{
    public partial class FormAnswer : Form
    {
        // フィールド
        public MainForm frm_main; // 親の参照先

        public string no_answer;
        public string str_answer;
        public string description;

        public FormAnswer(string no_answer, string str_answer, string description)
        {
            InitializeComponent();
            this.no_answer = no_answer;
            this.str_answer = str_answer;
            this.description = description;
        }

        private void FormAnswer_Load(object sender, EventArgs e)
        {
            label_no_collect.Text = no_answer;
            textBox_answer.Text = str_answer;
            textBox_description.Text = description;
        }

        private void FormAnswer_FormClosed(object sender, FormClosedEventArgs e)
        {
            //インデックスを増加
            frm_main.increment_quiz_index();

            // ステータスをdisableにする
            frm_main.frm_FormAnswer_enable = false;
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
