namespace English_NumerOn
{
    partial class Form1
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
            this.textBox1_write = new System.Windows.Forms.TextBox();
            this.button1_decision = new System.Windows.Forms.Button();
            this.listBox1_writewordlist = new System.Windows.Forms.ListBox();
            this.textBox2_answer = new System.Windows.Forms.TextBox();
            this.button2_answer = new System.Windows.Forms.Button();
            this.label1_anounce = new System.Windows.Forms.Label();
            this.button3_random = new System.Windows.Forms.Button();
            this.button4_retire = new System.Windows.Forms.Button();
            this.button5_ModeChange = new System.Windows.Forms.Button();
            this.label_CurrentModeView = new System.Windows.Forms.Label();
            this.button6_GameReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1_write
            // 
            this.textBox1_write.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_write.Location = new System.Drawing.Point(24, 357);
            this.textBox1_write.Multiline = true;
            this.textBox1_write.Name = "textBox1_write";
            this.textBox1_write.Size = new System.Drawing.Size(660, 234);
            this.textBox1_write.TabIndex = 0;
            this.textBox1_write.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1_write.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1_write.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1_write.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button1_decision
            // 
            this.button1_decision.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1_decision.Location = new System.Drawing.Point(703, 525);
            this.button1_decision.Name = "button1_decision";
            this.button1_decision.Size = new System.Drawing.Size(180, 66);
            this.button1_decision.TabIndex = 1;
            this.button1_decision.Text = "単語確定";
            this.button1_decision.UseVisualStyleBackColor = true;
            this.button1_decision.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listBox1_writewordlist
            // 
            this.listBox1_writewordlist.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1_writewordlist.FormattingEnabled = true;
            this.listBox1_writewordlist.ItemHeight = 31;
            this.listBox1_writewordlist.Location = new System.Drawing.Point(915, 43);
            this.listBox1_writewordlist.Name = "listBox1_writewordlist";
            this.listBox1_writewordlist.Size = new System.Drawing.Size(396, 562);
            this.listBox1_writewordlist.TabIndex = 2;
            // 
            // textBox2_answer
            // 
            this.textBox2_answer.Font = new System.Drawing.Font("MV Boli", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_answer.Location = new System.Drawing.Point(24, 47);
            this.textBox2_answer.Multiline = true;
            this.textBox2_answer.Name = "textBox2_answer";
            this.textBox2_answer.Size = new System.Drawing.Size(660, 234);
            this.textBox2_answer.TabIndex = 3;
            this.textBox2_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2_answer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2_answer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            this.textBox2_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // button2_answer
            // 
            this.button2_answer.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2_answer.Location = new System.Drawing.Point(703, 47);
            this.button2_answer.Name = "button2_answer";
            this.button2_answer.Size = new System.Drawing.Size(180, 86);
            this.button2_answer.TabIndex = 4;
            this.button2_answer.Text = "回答！";
            this.button2_answer.UseVisualStyleBackColor = true;
            this.button2_answer.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1_anounce
            // 
            this.label1_anounce.Font = new System.Drawing.Font("HG創英角ﾎﾟｯﾌﾟ体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1_anounce.Location = new System.Drawing.Point(911, 8);
            this.label1_anounce.Name = "label1_anounce";
            this.label1_anounce.Size = new System.Drawing.Size(400, 32);
            this.label1_anounce.TabIndex = 5;
            this.label1_anounce.Text = "入力履歴です";
            this.label1_anounce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3_random
            // 
            this.button3_random.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3_random.Location = new System.Drawing.Point(703, 446);
            this.button3_random.Name = "button3_random";
            this.button3_random.Size = new System.Drawing.Size(180, 73);
            this.button3_random.TabIndex = 6;
            this.button3_random.Text = "ランダム";
            this.button3_random.UseVisualStyleBackColor = true;
            this.button3_random.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4_retire
            // 
            this.button4_retire.Font = new System.Drawing.Font("HG丸ｺﾞｼｯｸM-PRO", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4_retire.Location = new System.Drawing.Point(703, 195);
            this.button4_retire.Name = "button4_retire";
            this.button4_retire.Size = new System.Drawing.Size(180, 86);
            this.button4_retire.TabIndex = 7;
            this.button4_retire.Text = "諦め～";
            this.button4_retire.UseVisualStyleBackColor = true;
            this.button4_retire.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5_ModeChange
            // 
            this.button5_ModeChange.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5_ModeChange.Location = new System.Drawing.Point(12, 577);
            this.button5_ModeChange.Name = "button5_ModeChange";
            this.button5_ModeChange.Size = new System.Drawing.Size(145, 42);
            this.button5_ModeChange.TabIndex = 8;
            this.button5_ModeChange.Text = "モード切替";
            this.button5_ModeChange.UseVisualStyleBackColor = true;
            this.button5_ModeChange.Click += new System.EventHandler(this.button5_Click);
            // 
            // label_CurrentModeView
            // 
            this.label_CurrentModeView.AutoSize = true;
            this.label_CurrentModeView.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_CurrentModeView.Location = new System.Drawing.Point(22, 11);
            this.label_CurrentModeView.Name = "label_CurrentModeView";
            this.label_CurrentModeView.Size = new System.Drawing.Size(190, 24);
            this.label_CurrentModeView.TabIndex = 9;
            this.label_CurrentModeView.Text = "CurrentModeView";
            this.label_CurrentModeView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6_GameReset
            // 
            this.button6_GameReset.Font = new System.Drawing.Font("HG創英角ｺﾞｼｯｸUB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6_GameReset.Location = new System.Drawing.Point(703, 364);
            this.button6_GameReset.Name = "button6_GameReset";
            this.button6_GameReset.Size = new System.Drawing.Size(182, 76);
            this.button6_GameReset.TabIndex = 10;
            this.button6_GameReset.Text = "リセット";
            this.button6_GameReset.UseVisualStyleBackColor = true;
            this.button6_GameReset.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1316, 631);
            this.Controls.Add(this.button6_GameReset);
            this.Controls.Add(this.label_CurrentModeView);
            this.Controls.Add(this.button5_ModeChange);
            this.Controls.Add(this.button4_retire);
            this.Controls.Add(this.button3_random);
            this.Controls.Add(this.label1_anounce);
            this.Controls.Add(this.button2_answer);
            this.Controls.Add(this.textBox2_answer);
            this.Controls.Add(this.listBox1_writewordlist);
            this.Controls.Add(this.button1_decision);
            this.Controls.Add(this.textBox1_write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_write;
        private System.Windows.Forms.Button button1_decision;
        private System.Windows.Forms.ListBox listBox1_writewordlist;
        private System.Windows.Forms.TextBox textBox2_answer;
        private System.Windows.Forms.Button button2_answer;
        private System.Windows.Forms.Label label1_anounce;
        private System.Windows.Forms.Button button3_random;
        private System.Windows.Forms.Button button4_retire;
        private System.Windows.Forms.Button button5_ModeChange;
        private System.Windows.Forms.Label label_CurrentModeView;
        private System.Windows.Forms.Button button6_GameReset;
    }
}

