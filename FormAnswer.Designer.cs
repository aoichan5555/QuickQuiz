namespace QuickQuiz
{
    partial class FormAnswer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_return = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label_no_collect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_answer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_return
            // 
            this.button_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_return.Font = new System.Drawing.Font("MS UI Gothic", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_return.Location = new System.Drawing.Point(670, 833);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(568, 166);
            this.button_return.TabIndex = 1;
            this.button_return.Text = "OK";
            this.button_return.UseVisualStyleBackColor = false;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_description.Font = new System.Drawing.Font("MS UI Gothic", 44F, System.Drawing.FontStyle.Bold);
            this.textBox_description.Location = new System.Drawing.Point(29, 233);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(1844, 582);
            this.textBox_description.TabIndex = 4;
            this.textBox_description.Text = "解説";
            // 
            // label_no_collect
            // 
            this.label_no_collect.AutoSize = true;
            this.label_no_collect.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_no_collect.Location = new System.Drawing.Point(211, 9);
            this.label_no_collect.Name = "label_no_collect";
            this.label_no_collect.Size = new System.Drawing.Size(139, 97);
            this.label_no_collect.TabIndex = 9;
            this.label_no_collect.Text = "１";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ＭＳ ゴシック", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 97);
            this.label1.TabIndex = 10;
            this.label1.Text = "答";
            // 
            // textBox_answer
            // 
            this.textBox_answer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_answer.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Bold);
            this.textBox_answer.Location = new System.Drawing.Point(400, 16);
            this.textBox_answer.Multiline = true;
            this.textBox_answer.Name = "textBox_answer";
            this.textBox_answer.Size = new System.Drawing.Size(1473, 169);
            this.textBox_answer.TabIndex = 11;
            this.textBox_answer.Text = "ans1";
            // 
            // FormAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.textBox_answer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_no_collect);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.button_return);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnswer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Answer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAnswer_FormClosed);
            this.Load += new System.EventHandler(this.FormAnswer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_return;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label_no_collect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_answer;
    }
}