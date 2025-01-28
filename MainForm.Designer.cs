namespace QuickQuiz
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_answer = new System.Windows.Forms.Button();
            this.textBox_Question = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Option1 = new System.Windows.Forms.TextBox();
            this.textBox_Option2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_answer
            // 
            this.button_answer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_answer.Font = new System.Drawing.Font("MS UI Gothic", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_answer.Location = new System.Drawing.Point(691, 843);
            this.button_answer.Name = "button_answer";
            this.button_answer.Size = new System.Drawing.Size(568, 169);
            this.button_answer.TabIndex = 0;
            this.button_answer.Text = "Answer";
            this.button_answer.UseVisualStyleBackColor = false;
            this.button_answer.Click += new System.EventHandler(this.button_answer_Click);
            // 
            // textBox_Question
            // 
            this.textBox_Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox_Question.Font = new System.Drawing.Font("MS UI Gothic", 40F, System.Drawing.FontStyle.Bold);
            this.textBox_Question.Location = new System.Drawing.Point(41, 122);
            this.textBox_Question.Multiline = true;
            this.textBox_Question.Name = "textBox_Question";
            this.textBox_Question.Size = new System.Drawing.Size(1803, 322);
            this.textBox_Question.TabIndex = 3;
            this.textBox_Question.Text = "質問";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Font = new System.Drawing.Font("ＭＳ ゴシック", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelCategory.Location = new System.Drawing.Point(42, 22);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(439, 80);
            this.labelCategory.TabIndex = 4;
            this.labelCategory.Text = "カテゴリー";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(204, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 97);
            this.label3.TabIndex = 7;
            this.label3.Text = "１";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(204, 654);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 97);
            this.label4.TabIndex = 8;
            this.label4.Text = "２";
            // 
            // textBox_Option1
            // 
            this.textBox_Option1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Option1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.textBox_Option1.Location = new System.Drawing.Point(382, 492);
            this.textBox_Option1.Multiline = true;
            this.textBox_Option1.Name = "textBox_Option1";
            this.textBox_Option1.Size = new System.Drawing.Size(1462, 169);
            this.textBox_Option1.TabIndex = 9;
            this.textBox_Option1.Text = "ans1";
            // 
            // textBox_Option2
            // 
            this.textBox_Option2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Option2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.textBox_Option2.Location = new System.Drawing.Point(382, 667);
            this.textBox_Option2.Multiline = true;
            this.textBox_Option2.Name = "textBox_Option2";
            this.textBox_Option2.Size = new System.Drawing.Size(1462, 169);
            this.textBox_Option2.TabIndex = 10;
            this.textBox_Option2.Text = "ans2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.textBox_Option2);
            this.Controls.Add(this.textBox_Option1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBox_Question);
            this.Controls.Add(this.button_answer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuickQuiz";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_answer;
        private System.Windows.Forms.TextBox textBox_Question;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Option1;
        private System.Windows.Forms.TextBox textBox_Option2;
    }
}

