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
            textBox1_write.MaxLength = 5; 
            textBox2_answer.MaxLength = 5;
        }
        /// <summary>
        /// 起動時及びリセット時に処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("本プログラムの無断転載、複製、改変等を禁止いたします");
            MessageBox.Show("好きな5文字の英単語を左下に入力してね");
            MessageBox.Show("右のボタンを押して確定してね");
            label_CurrentModeView.Text = "モード: アルファベット,５字";
            button2_answer.Enabled = false;
            button4_retire.Enabled = false;
            textBox2_answer.Enabled=false;
        }
        /// <summary>
        /// 単語確定ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1_write.Text.Trim().ToLower();
            if (input.Length != textBox1_write.MaxLength)
            {
                MessageBox.Show("5文字の英単語を入力してください");
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                TargetWords[i] = input[i];
            }
            listBox1_writewordlist.Items.Clear();
            textBox1_write.Clear();
            textBox2_answer.Clear();
            MessageBox.Show("単語が入力されました！\r\n回答者に交代してね");
            MessageBox.Show("左上に英単語を入力してね！");
            MessageBox.Show("右のボタンで回答してね！");
            button5_ModeChange.Enabled = false;
            button2_answer.Enabled = true;
            button4_retire.Enabled = true;
            textBox1_write.Enabled = false;
            textBox2_answer.Enabled = true;

        }
        /// <summary>
        ///回答ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string guess = textBox2_answer.Text.Trim().ToLower();
            if (guess.Length != textBox2_answer.MaxLength)
            {
                MessageBox.Show("5文字の英単語を入力してください");
                return;
            }
            for (int i = 0; i < 5; i++)
            {
                GuessWords[i] = guess[i];
            }
            int hit = 0, blow = 0;
            // ターゲットの各文字の出現回数
            Dictionary<char, int> targetCount = new Dictionary<char, int>();
            for (int i = 0; i < 5; i++)
            {
                char t = TargetWords[i];
                if (!targetCount.ContainsKey(t)) targetCount[t] = 0;
                targetCount[t]++;
            }

            bool[] isHit = new bool[5];
            for (int i = 0; i < 5; i++)
            {
                if (GuessWords[i] == TargetWords[i])
                {
                    hit++;
                    isHit[i] = true;
                    targetCount[GuessWords[i]]--; 
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (isHit[i]) continue; 
                char g = GuessWords[i];
                if (targetCount.TryGetValue(g, out int remaining) && remaining > 0)
                {
                    blow++;
                    targetCount[g]--; 
                }
            }

            listBox1_writewordlist.Items.Add($"{guess.ToUpper()} → Hit: {hit}, Blow: {blow}");
            listBox1_writewordlist.TopIndex = listBox1_writewordlist.Items.Count - 1;
            if (hit == textBox1_write.MaxLength)
            {
                MessageBox.Show("おみごと！クリアです！");
                ResetGame();
                return;
            }
            textBox2_answer.Clear();
        }
        /// <summary>
        /// ランダムな英単語を問題に設定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string selected = _WordList[rand.Next(_WordList.Count)];
            for (int i = 0; i < 5; i++)
            {
                TargetWords[i] = selected[i];
            }
            listBox1_writewordlist.Items.Clear();
            textBox1_write.Clear();
            MessageBox.Show("ランダム単語が選ばれました！\r\n回答者に交代してね");
            MessageBox.Show("左上に英単語を入力してね！");
            MessageBox.Show("右のボタンで回答してね！");
            button5_ModeChange.Enabled = false;
            button2_answer.Enabled = true;
            button4_retire.Enabled = true;
            textBox1_write.Enabled = false;
            textBox2_answer.Enabled = true;

        }
        /// <summary>
        /// ランダム単語リスト
        /// </summary>
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
              //"","","","","", //単語リスト追加用スペース
        };
        /// <summary>
        /// ギブアップボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            string answer = new string(TargetWords);
            MessageBox.Show($"「{answer.ToUpper()}」\r\n知らないの？");
            ResetGame();
        }

        enum InputMode
        {
            AlphabetOnly,
            Any
        }
        private InputMode currentMode = InputMode.AlphabetOnly;
        /// <summary>
        /// モード切替ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (currentMode == InputMode.AlphabetOnly)
            {
                currentMode = InputMode.Any;
                label_CurrentModeView.Text = "モード: 制限なし,５字";
                MessageBox.Show("制限なしモードに切り替えました");
            }
            else
            {
                currentMode = InputMode.AlphabetOnly;
                label_CurrentModeView.Text = "モード: アルファベット";
                MessageBox.Show("アルファベットのみモードに切り替えました");
            }
        }
        /// <summary>
        /// コピペ禁止とエンターで文字確定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true; 
            }
            if (e.KeyCode == Keys.Enter)
            {
                button1_decision.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// コピペ禁止とエンターで文字確定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Enter)
            {
                button2_answer.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        /// <summary>
        /// モードと違う文字の削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentMode == InputMode.AlphabetOnly)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
        }
        /// <summary>
        /// モードと違う文字の削除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (currentMode == InputMode.AlphabetOnly)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }
        /// <summary>
        /// 文字入力時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentMode == InputMode.AlphabetOnly)
            {
                string original = textBox1_write.Text;
                string filtered = new string(original
                    .Where(c => char.IsLetter(c) && c <= 'z' && c >= 'a' || c <= 'Z' && c >= 'A')
                    .ToArray());
                if (original != filtered)
                {
                    int pos = textBox1_write.SelectionStart;
                    textBox1_write.Text = filtered;
                    // カーソル位置を維持
                    textBox1_write.SelectionStart = Math.Min(pos, filtered.Length);
                }
            }
        }
        /// <summary>
        /// 文字入力時処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (currentMode == InputMode.AlphabetOnly)
            {
                string original = textBox2_answer.Text;
                string filtered = new string(original
                    .Where(c => char.IsLetter(c) && c <= 'z' && c >= 'a' || c <= 'Z' && c >= 'A')
                    .ToArray());
                if (original != filtered)
                {
                    int pos = textBox2_answer.SelectionStart;
                    textBox2_answer.Text = filtered;
                    textBox2_answer.SelectionStart = Math.Min(pos, filtered.Length);
                }
            }
        }

       

        /// <summary>
        /// リセットボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        /// <summary>
        /// 初期化
        /// </summary>
        private void ResetGame()
        {
            // 配列初期化
            TargetWords = new char[5];
            GuessWords = new char[5];
            textBox1_write.Clear();
            textBox2_answer.Clear();
            listBox1_writewordlist.Items.Clear();
            // モードを初期状態に戻す
            currentMode = InputMode.AlphabetOnly;
            label_CurrentModeView.Text = "モード: アルファベット";
            // モード切替ボタンを再度有効化
            button5_ModeChange.Enabled = true;
            button2_answer.Enabled = false;
            button4_retire.Enabled = false;
            textBox1_write.Enabled = true;
            textBox2_answer.Enabled=false;

            MessageBox.Show("リセットしました！新しいゲームを始められます");
        }
        //６文字モード、ヒントボタン、追加するかも
        //ランダムモードで、ジャンルわけ
        //テキストファイルからランダム単語リストとして選択できるようにしたい。
    }
}