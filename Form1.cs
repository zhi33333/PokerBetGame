using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1133330_陳芷姍_撲克牌
{
    public partial class Form1 : Form
    {
        // 牌堆
        private List<Card> deck = new List<Card>();

        // 玩家手上的五張牌
        private List<Card> hand = new List<Card>();

        // 玩家總資金
        private int money = 1000000;

        // 目前下注金額
        private int currentBet = 0;

        // 亂數
        private Random rnd = new Random();

        // 五張牌的 Label 陣列
        private Label[] cardLabels;

        // 紀錄哪幾張牌被選取要換牌
        private bool[] selected = new bool[5];
        private Image cardBackImage;
        public Form1()
        {
            InitializeComponent();
            cardLabels = new Label[]
            {
                lblCard1, lblCard2, lblCard3, lblCard4, lblCard5
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始金額
            txtMoney.Text = money.ToString();

            // 初始押注金額
            txtBet.Text = "500";

            // 初始結果文字
            lblResult.Text = "請先下注，然後按發牌。";

            // 初始按鈕狀態
            btnBet.Enabled = true;
            btnDeal.Enabled = false;
            btnExchange.Enabled = false;
            btnJudge.Enabled = false;
            lblCard1.TabStop = true;
            lblCard2.TabStop = true;
            lblCard3.TabStop = true;
            lblCard4.TabStop = true;
            lblCard5.TabStop = true;
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            txtBet.KeyPress += txtBet_KeyPress;

            txtMoney.TabStop = false;

            txtBet.TabIndex = 0;
            btnBet.TabIndex = 1;
            btnDeal.TabIndex = 2;
            lblCard1.TabIndex = 3;
            lblCard2.TabIndex = 4;
            lblCard3.TabIndex = 5;
            lblCard4.TabIndex = 6;
            lblCard5.TabIndex = 7;
            btnExchange.TabIndex = 8;
            btnJudge.TabIndex = 9;

            lblCard1.TabStop = true;
            lblCard2.TabStop = true;
            lblCard3.TabStop = true;
            lblCard4.TabStop = true;
            lblCard5.TabStop = true;
            cardBackImage = Image.FromFile("card.png");
            // 設定牌背
            SetCardsBack();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBet.Text, out currentBet))
            {
                MessageBox.Show("請輸入正確的押注金額！");
                return;
            }

            // 檢查是否大於 0
            if (currentBet <= 0)
            {
                MessageBox.Show("押注金額必須大於 0！");
                return;
            }

            // 檢查是否超過總資金
            if (currentBet > money)
            {
                MessageBox.Show("押注金額不能超過總資金！");
                return;
            }

            // 扣掉下注金額
            money -= currentBet;
            txtMoney.Text = money.ToString();

            lblResult.Text = "下注成功！請按發牌。";

            // 下注後才能發牌
            btnBet.Enabled = false;
            btnDeal.Enabled = true;
            btnExchange.Enabled = false;
            btnJudge.Enabled = false;
            btnDeal.Focus();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            // 建立牌堆
            CreateDeck();

            // 洗牌
            ShuffleDeck();

            // 清空手牌
            hand.Clear();

            // 發五張牌
            for (int i = 0; i < 5; i++)
            {
                hand.Add(deck[0]);
                deck.RemoveAt(0);
                selected[i] = false;
            }

            // 顯示牌
            ShowCards();

            lblResult.Text = "發牌完成！可點選牌後按換牌，或直接判斷牌型。";

            btnDeal.Enabled = false;
            btnExchange.Enabled = true;
            btnJudge.Enabled = true;
            btnExchange.Focus();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            // 將被選取的牌換掉
            for (int i = 0; i < 5; i++)
            {
                if (selected[i])
                {
                    hand[i] = deck[0];
                    deck.RemoveAt(0);
                    selected[i] = false;
                }
            }

            // 顯示換完後的牌
            ShowCards();

            lblResult.Text = "換牌完成！請按判斷牌型。";

            // 一局只給換一次牌
            btnExchange.Enabled = false;
            btnJudge.Focus();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // 如果游標正在押注金額 txtBet 裡面
            // 數字鍵要拿來輸入金額，不要拿來選牌
            if (this.ActiveControl == txtBet)
            {
                if (keyData == Keys.Enter)
                {
                    btnBet.PerformClick();
                    return true;
                }

                return base.ProcessCmdKey(ref msg, keyData);
            }

            // 數字 1~5 選牌，上排數字鍵
            if (keyData == Keys.D1)
            {
                ToggleCardByNumber(0);
                return true;
            }
            else if (keyData == Keys.D2)
            {
                ToggleCardByNumber(1);
                return true;
            }
            else if (keyData == Keys.D3)
            {
                ToggleCardByNumber(2);
                return true;
            }
            else if (keyData == Keys.D4)
            {
                ToggleCardByNumber(3);
                return true;
            }
            else if (keyData == Keys.D5)
            {
                ToggleCardByNumber(4);
                return true;
            }

            // 數字鍵盤 NumPad 1~5 也可以選牌
            else if (keyData == Keys.NumPad1)
            {
                ToggleCardByNumber(0);
                return true;
            }
            else if (keyData == Keys.NumPad2)
            {
                ToggleCardByNumber(1);
                return true;
            }
            else if (keyData == Keys.NumPad3)
            {
                ToggleCardByNumber(2);
                return true;
            }
            else if (keyData == Keys.NumPad4)
            {
                ToggleCardByNumber(3);
                return true;
            }
            else if (keyData == Keys.NumPad5)
            {
                ToggleCardByNumber(4);
                return true;
            }

            // 英文快捷鍵
            else if (keyData == Keys.B)
            {
                btnBet.PerformClick();
                return true;
            }
            else if (keyData == Keys.D)
            {
                btnDeal.PerformClick();
                return true;
            }
            else if (keyData == Keys.E)
            {
                btnExchange.PerformClick();
                return true;
            }
            else if (keyData == Keys.J)
            {
                btnJudge.PerformClick();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void btnJudge_Click(object sender, EventArgs e)
        {
            string handName;

            // 取得牌型賠率
            int rate = GetHandRate(out handName);

            // 計算中獎金額
            int winMoney = currentBet * rate;

            if (rate > 0)
            {
                money += winMoney;
                lblResult.Text = $"結果：{handName}，賠率 {rate} 倍，中獎 {winMoney}";
            }
            else
            {
                lblResult.Text = "結果：無中獎牌型，沒有中獎。";
            }

            txtMoney.Text = money.ToString();

            // 一局結束，回到可下注狀態
            btnBet.Enabled = true;
            btnDeal.Enabled = false;
            btnExchange.Enabled = false;
            btnJudge.Enabled = false;
            if (money <= 0)
            {
                MessageBox.Show("你的資金已經歸零，遊戲結束！");
                btnBet.Enabled = false;
                btnDeal.Enabled = false;
                btnExchange.Enabled = false;
                btnJudge.Enabled = false;
                txtBet.Focus();
                txtBet.SelectAll();
            }
        }
        private void Card_Click(object sender, EventArgs e)
        {
            Label clickedLabel = sender as Label;

            for (int i = 0; i < cardLabels.Length; i++)
            {
                if (clickedLabel == cardLabels[i])
                {
                    ToggleCardByNumber(i);
                    break;
                }
            }
        }

        private void CreateDeck()
        {
            deck.Clear();

            string[] suits = { "♠", "♥", "♦", "♣" };

            for (int s = 0; s < suits.Length; s++)
            {
                for (int r = 1; r <= 13; r++)
                {
                    deck.Add(new Card(suits[s], r));
                }
            }
        }

        private void ShuffleDeck()
        {
            deck = deck.OrderBy(card => rnd.Next()).ToList();
        }

        private void ShowCards()
        {
            for (int i = 0; i < 5; i++)
            {
                cardLabels[i].BackgroundImage = null;
                cardLabels[i].Image = null;

                cardLabels[i].Text = hand[i].GetDisplayText();

                cardLabels[i].BackColor = Color.White;
                cardLabels[i].BorderStyle = BorderStyle.FixedSingle;
                cardLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                if (hand[i].Suit == "♥" || hand[i].Suit == "♦")
                {
                    cardLabels[i].ForeColor = Color.Red;
                }
                else
                {
                    cardLabels[i].ForeColor = Color.Black;
                }
            }
        }

        private void SetCardsBack()
        {
            for (int i = 0; i < cardLabels.Length; i++)
            {
                cardLabels[i].Text = "";

                cardLabels[i].Image = null;
                cardLabels[i].BackgroundImage = cardBackImage;
                cardLabels[i].BackgroundImageLayout = ImageLayout.Stretch;

                cardLabels[i].BackColor = Color.White;
                cardLabels[i].ForeColor = Color.Black;
                cardLabels[i].BorderStyle = BorderStyle.FixedSingle;
                cardLabels[i].TextAlign = ContentAlignment.MiddleCenter;

                selected[i] = false;
            }
        }

        private int GetHandRate(out string handName)
        {
            List<int> ranks = hand
                .Select(card => card.Rank)
                .OrderBy(rank => rank)
                .ToList();

            List<string> suits = hand
                .Select(card => card.Suit)
                .ToList();

            bool isFlush = suits.Distinct().Count() == 1;
            bool isStraight = IsStraight(ranks);

            var groups = ranks
                .GroupBy(rank => rank)
                .Select(group => new
                {
                    Rank = group.Key,
                    Count = group.Count()
                })
                .OrderByDescending(group => group.Count)
                .ToList();

            bool isRoyalFlush =
                isFlush &&
                ranks.Contains(1) &&
                ranks.Contains(10) &&
                ranks.Contains(11) &&
                ranks.Contains(12) &&
                ranks.Contains(13);

            if (isRoyalFlush)
            {
                handName = "皇家同花順";
                return 250;
            }

            if (isFlush && isStraight)
            {
                handName = "同花順";
                return 50;
            }

            if (groups[0].Count == 4)
            {
                handName = "四條";
                return 25;
            }

            if (groups[0].Count == 3 && groups[1].Count == 2)
            {
                handName = "葫蘆";
                return 9;
            }

            if (isFlush)
            {
                handName = "同花";
                return 6;
            }

            if (isStraight)
            {
                handName = "順子";
                return 4;
            }

            if (groups[0].Count == 3)
            {
                handName = "三條";
                return 3;
            }

            if (groups[0].Count == 2 && groups[1].Count == 2)
            {
                handName = "兩對";
                return 2;
            }

            if (groups[0].Count == 2)
            {
                handName = "一對";
                return 1;
            }

            handName = "無";
            return 0;
        }
        private void ToggleCardByNumber(int index)
        {
            // 還沒發牌時不能選牌
            if (hand.Count < 5)
            {
                return;
            }

            selected[index] = !selected[index];

            if (selected[index])
            {
                cardLabels[index].BackColor = Color.LightYellow;
                cardLabels[index].BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                cardLabels[index].BackColor = Color.White;
                cardLabels[index].BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private bool IsStraight(List<int> ranks)
        {
            ranks = ranks
                .Distinct()
                .OrderBy(rank => rank)
                .ToList();

            if (ranks.Count != 5)
            {
                return false;
            }

            // 一般順子，例如 4,5,6,7,8
            bool normalStraight = true;

            for (int i = 0; i < ranks.Count - 1; i++)
            {
                if (ranks[i + 1] - ranks[i] != 1)
                {
                    normalStraight = false;
                    break;
                }
            }

            // A,2,3,4,5
            bool smallStraight = ranks.SequenceEqual(new List<int> { 1, 2, 3, 4, 5 });

            // 10,J,Q,K,A
            bool bigStraight = ranks.SequenceEqual(new List<int> { 1, 10, 11, 12, 13 });

            return normalStraight || smallStraight || bigStraight;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 如果目前游標在押注金額 txtBet 裡
            if (this.ActiveControl == txtBet)
            {
                // 在 txtBet 裡按 Enter，就執行下注
                if (e.KeyCode == Keys.Enter)
                {
                    btnBet.PerformClick();
                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }

                // 其他按鍵交給 txtBet 自己處理
                // 例如數字就是輸入押注金額
                return;
            }

            // Enter 或 Space：執行目前選到的控制項
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
            {
                Control active = this.ActiveControl;

                if (active == btnBet)
                {
                    btnBet.PerformClick();
                }
                else if (active == btnDeal)
                {
                    btnDeal.PerformClick();
                }
                else if (active == btnExchange)
                {
                    btnExchange.PerformClick();
                }
                else if (active == btnJudge)
                {
                    btnJudge.PerformClick();
                }
                else if (active == lblCard1)
                {
                    Card_Click(lblCard1, EventArgs.Empty);
                }
                else if (active == lblCard2)
                {
                    Card_Click(lblCard2, EventArgs.Empty);
                }
                else if (active == lblCard3)
                {
                    Card_Click(lblCard3, EventArgs.Empty);
                }
                else if (active == lblCard4)
                {
                    Card_Click(lblCard4, EventArgs.Empty);
                }
                else if (active == lblCard5)
                {
                    Card_Click(lblCard5, EventArgs.Empty);
                }

                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // 快捷鍵：只有游標不在 txtBet 時才會啟動
            if (e.KeyCode == Keys.B)
            {
                btnBet.PerformClick();
            }
            else if (e.KeyCode == Keys.D)
            {
                btnDeal.PerformClick();
            }
            else if (e.KeyCode == Keys.E)
            {
                btnExchange.PerformClick();
            }
            else if (e.KeyCode == Keys.J)
            {
                btnJudge.PerformClick();
            }
            else if (e.KeyCode == Keys.D1)
            {
                Card_Click(lblCard1, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D2)
            {
                Card_Click(lblCard2, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D3)
            {
                Card_Click(lblCard3, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D4)
            {
                Card_Click(lblCard4, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.D5)
            {
                Card_Click(lblCard5, EventArgs.Empty);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtBet_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 允許數字、Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }


    public class Card
    {
        public string Suit { get; set; }
        public int Rank { get; set; }

        public Card(string suit, int rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public string GetDisplayText()
        {
            string rankText;

            if (Rank == 1)
            {
                rankText = "A";
            }
            else if (Rank == 11)
            {
                rankText = "J";
            }
            else if (Rank == 12)
            {
                rankText = "Q";
            }
            else if (Rank == 13)
            {
                rankText = "K";
            }
            else
            {
                rankText = Rank.ToString();
            }

            return Suit + "\n" + rankText;
        }
    }
}

