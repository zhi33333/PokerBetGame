namespace _1133330_陳芷姍_撲克牌
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxTable = new System.Windows.Forms.GroupBox();
            this.lblCard4 = new System.Windows.Forms.Label();
            this.lblCard3 = new System.Windows.Forms.Label();
            this.lblCard2 = new System.Windows.Forms.Label();
            this.lblCard5 = new System.Windows.Forms.Label();
            this.lblCard1 = new System.Windows.Forms.Label();
            this.groupBoxBet = new System.Windows.Forms.GroupBox();
            this.btnBet = new System.Windows.Forms.Button();
            this.txtBet = new System.Windows.Forms.TextBox();
            this.lblBetTitle = new System.Windows.Forms.Label();
            this.lblMoneyTitle = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.groupBoxFunction = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnJudge = new System.Windows.Forms.Button();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnDeal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTable.SuspendLayout();
            this.groupBoxBet.SuspendLayout();
            this.groupBoxFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTable
            // 
            this.groupBoxTable.Controls.Add(this.lblCard4);
            this.groupBoxTable.Controls.Add(this.lblCard3);
            this.groupBoxTable.Controls.Add(this.lblCard2);
            this.groupBoxTable.Controls.Add(this.lblCard5);
            this.groupBoxTable.Controls.Add(this.lblCard1);
            this.groupBoxTable.Location = new System.Drawing.Point(20, 20);
            this.groupBoxTable.Name = "groupBoxTable";
            this.groupBoxTable.Size = new System.Drawing.Size(660, 220);
            this.groupBoxTable.TabIndex = 0;
            this.groupBoxTable.TabStop = false;
            this.groupBoxTable.Text = "牌桌";
            // 
            // lblCard4
            // 
            this.lblCard4.Location = new System.Drawing.Point(400, 40);
            this.lblCard4.Name = "lblCard4";
            this.lblCard4.Size = new System.Drawing.Size(110, 150);
            this.lblCard4.TabIndex = 6;
            this.lblCard4.Text = "label1";
            this.lblCard4.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCard3
            // 
            this.lblCard3.Location = new System.Drawing.Point(275, 40);
            this.lblCard3.Name = "lblCard3";
            this.lblCard3.Size = new System.Drawing.Size(110, 150);
            this.lblCard3.TabIndex = 5;
            this.lblCard3.Text = "label1";
            this.lblCard3.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCard2
            // 
            this.lblCard2.Location = new System.Drawing.Point(150, 40);
            this.lblCard2.Name = "lblCard2";
            this.lblCard2.Size = new System.Drawing.Size(110, 150);
            this.lblCard2.TabIndex = 4;
            this.lblCard2.Text = "label1";
            this.lblCard2.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCard5
            // 
            this.lblCard5.Location = new System.Drawing.Point(525, 40);
            this.lblCard5.Name = "lblCard5";
            this.lblCard5.Size = new System.Drawing.Size(110, 150);
            this.lblCard5.TabIndex = 7;
            this.lblCard5.Text = "label1";
            this.lblCard5.Click += new System.EventHandler(this.Card_Click);
            // 
            // lblCard1
            // 
            this.lblCard1.Location = new System.Drawing.Point(25, 40);
            this.lblCard1.Name = "lblCard1";
            this.lblCard1.Size = new System.Drawing.Size(110, 150);
            this.lblCard1.TabIndex = 3;
            this.lblCard1.Text = "ooo";
            this.lblCard1.Click += new System.EventHandler(this.Card_Click);
            // 
            // groupBoxBet
            // 
            this.groupBoxBet.Controls.Add(this.btnBet);
            this.groupBoxBet.Controls.Add(this.txtBet);
            this.groupBoxBet.Controls.Add(this.lblBetTitle);
            this.groupBoxBet.Controls.Add(this.lblMoneyTitle);
            this.groupBoxBet.Controls.Add(this.txtMoney);
            this.groupBoxBet.Location = new System.Drawing.Point(20, 260);
            this.groupBoxBet.Name = "groupBoxBet";
            this.groupBoxBet.Size = new System.Drawing.Size(660, 75);
            this.groupBoxBet.TabIndex = 6;
            this.groupBoxBet.TabStop = false;
            this.groupBoxBet.Text = "下注";
            // 
            // btnBet
            // 
            this.btnBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnBet.Location = new System.Drawing.Point(480, 27);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(120, 30);
            this.btnBet.TabIndex = 1;
            this.btnBet.Text = "下注";
            this.btnBet.UseVisualStyleBackColor = false;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // txtBet
            // 
            this.txtBet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtBet.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBet.Location = new System.Drawing.Point(330, 30);
            this.txtBet.Name = "txtBet";
            this.txtBet.Size = new System.Drawing.Size(120, 25);
            this.txtBet.TabIndex = 0;
            this.txtBet.Text = "500";
            this.txtBet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBet_KeyPress);
            // 
            // lblBetTitle
            // 
            this.lblBetTitle.AutoSize = true;
            this.lblBetTitle.Location = new System.Drawing.Point(250, 32);
            this.lblBetTitle.Name = "lblBetTitle";
            this.lblBetTitle.Size = new System.Drawing.Size(67, 15);
            this.lblBetTitle.TabIndex = 2;
            this.lblBetTitle.Text = "押注金額";
            // 
            // lblMoneyTitle
            // 
            this.lblMoneyTitle.AutoSize = true;
            this.lblMoneyTitle.Location = new System.Drawing.Point(20, 32);
            this.lblMoneyTitle.Name = "lblMoneyTitle";
            this.lblMoneyTitle.Size = new System.Drawing.Size(52, 15);
            this.lblMoneyTitle.TabIndex = 1;
            this.lblMoneyTitle.Text = "總資金";
            // 
            // txtMoney
            // 
            this.txtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMoney.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMoney.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtMoney.Location = new System.Drawing.Point(85, 30);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(120, 25);
            this.txtMoney.TabIndex = 0;
            this.txtMoney.TabStop = false;
            this.txtMoney.Text = "1000000";
            this.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxFunction
            // 
            this.groupBoxFunction.Controls.Add(this.lblResult);
            this.groupBoxFunction.Controls.Add(this.btnJudge);
            this.groupBoxFunction.Controls.Add(this.btnExchange);
            this.groupBoxFunction.Controls.Add(this.btnDeal);
            this.groupBoxFunction.Location = new System.Drawing.Point(20, 355);
            this.groupBoxFunction.Name = "groupBoxFunction";
            this.groupBoxFunction.Size = new System.Drawing.Size(660, 95);
            this.groupBoxFunction.TabIndex = 7;
            this.groupBoxFunction.TabStop = false;
            this.groupBoxFunction.Text = "功能";
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblResult.Location = new System.Drawing.Point(365, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(270, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "結果顯示";
            // 
            // btnJudge
            // 
            this.btnJudge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnJudge.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnJudge.Location = new System.Drawing.Point(245, 35);
            this.btnJudge.Name = "btnJudge";
            this.btnJudge.Size = new System.Drawing.Size(90, 35);
            this.btnJudge.TabIndex = 9;
            this.btnJudge.TabStop = false;
            this.btnJudge.Text = "判斷牌型";
            this.btnJudge.UseVisualStyleBackColor = false;
            this.btnJudge.Click += new System.EventHandler(this.btnJudge_Click);
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExchange.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnExchange.Location = new System.Drawing.Point(135, 35);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(90, 35);
            this.btnExchange.TabIndex = 8;
            this.btnExchange.TabStop = false;
            this.btnExchange.Text = "換牌";
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnDeal
            // 
            this.btnDeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDeal.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(25, 35);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(90, 35);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.TabStop = false;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = false;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(20, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "快捷鍵：D發牌、1~5選牌、E換牌、J判斷";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 497);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxFunction);
            this.Controls.Add(this.groupBoxBet);
            this.Controls.Add(this.groupBoxTable);
            this.Name = "Form1";
            this.Text = "五張撲克牌";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBoxTable.ResumeLayout(false);
            this.groupBoxBet.ResumeLayout(false);
            this.groupBoxBet.PerformLayout();
            this.groupBoxFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTable;
        private System.Windows.Forms.Label lblCard4;
        private System.Windows.Forms.Label lblCard3;
        private System.Windows.Forms.Label lblCard2;
        private System.Windows.Forms.Label lblCard5;
        private System.Windows.Forms.Label lblCard1;
        private System.Windows.Forms.GroupBox groupBoxBet;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.TextBox txtBet;
        private System.Windows.Forms.Label lblBetTitle;
        private System.Windows.Forms.Label lblMoneyTitle;
        private System.Windows.Forms.GroupBox groupBoxFunction;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Label label1;
    }
}

