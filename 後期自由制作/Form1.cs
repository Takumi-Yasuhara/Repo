using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace English_NumerOn
{
    public partial class Form1 : Form
    {

        char[] TargetWords = new char[5];
        char[] GuessWords = new char[5];

        public Form1()
        {
            InitializeComponent();
            textBox1.MaxLength = 5; // 入力制限
            textBox2.MaxLength = 5; // 入力制限
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            MessageBox.Show("好きな5文字の英単語を左下に入力してね");
            MessageBox.Show("右のボタンを押して確定してね");
            labelMode.Text = "現在";
           


        }




        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim().ToLower();
            if (input.Length != textBox1.MaxLength)
            {
                MessageBox.Show("5文字の英単語を入力してください");
                
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                TargetWords[i] = input[i];
            }
            listBox1.Items.Clear();
            textBox1.Clear();
            textBox2.Clear();

            //ResetTextBoxState(textBox1);
            MessageBox.Show("単語が入力されました！\r\n回答者に交代してね");
            MessageBox.Show("左上に英単語を入力してね！");
            MessageBox.Show("右のボタンで回答してね！");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string guess = textBox2.Text.Trim().ToLower();

            if (guess.Length != textBox2.MaxLength)
            {
                MessageBox.Show("5文字の英単語を入力してください");

                return;
            }

            for (int i = 0; i < 5; i++)
            {
                GuessWords[i] = guess[i];
            }

            int hit = 0, blow = 0;
            for (int i = 0; i < 5; i++)
            {
                if (GuessWords[i] == TargetWords[i]) hit++;
                else if (TargetWords.Contains(GuessWords[i])) blow++;
            }

            listBox1.Items.Add($"{guess.ToUpper()} → Hit: {hit}, Blow: {blow}");
            listBox1.TopIndex = listBox1.Items.Count - 1;

            if (hit == textBox1.MaxLength)
            {
                MessageBox.Show("おみごと！クリアです！");
            }
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string selected = _WordList[rand.Next(_WordList.Count)];
            for (int i = 0; i < 5; i++)
            {
                TargetWords[i] = selected[i];
            }
            listBox1.Items.Clear();
            textBox1.Clear();
            //textBox2.Enabled = true;
            //button2.Enabled = true;
            MessageBox.Show($"ランダム単語が選ばれました！\r\n回答者に交代してね");
            MessageBox.Show("左上に英単語を入力してね！");
            MessageBox.Show("右のボタンで回答してね！");
        }

        List<string> _WordList = new List<string>
        {
              "apple", "grape", "lemon", "mango", "peach",
              "bread", "chair", "dream", "eagle", "flame",
              "about","above","actor","adult","after",
              "again","agree","allow","alone","among",
              "alter","angel","apart","april","array",
              "arrow","asset","audio","avoid","awake",
              "aware","basic","batch","beach","beast",
              "below","berry","birth","black","blade",
              "blame","blank","blend","block","blood",
              "board","booth","bound","brain","brand",
              //"","","","","", 
              //"","","","","", 
              //"","","","","", --単語リスト追加用です

        };

        private void button4_Click(object sender, EventArgs e)
        {
            string answer = new string(TargetWords);

            // 答えを表示
            MessageBox.Show($"「{answer.ToUpper()}」\r\n知らないの？");
            textBox1.Clear();
            textBox2.Clear();
        }
        private void buttonModeChange_Click(object sender, EventArgs e)
        {
           
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; // Ctrl+V を無効化
            }

            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                button2.PerformClick();
                e.SuppressKeyPress = true;
            }
        }




        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
