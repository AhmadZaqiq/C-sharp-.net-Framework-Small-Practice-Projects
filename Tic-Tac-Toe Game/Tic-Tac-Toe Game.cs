using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toe_Game.Properties;

namespace Tic_Tac_Toe_Game
{
    public partial class FrmGame : Form
    {
        public FrmGame()
        {
            InitializeComponent();
        }

        enum enPlayer { Player1, Player2 };
        enPlayer playerTurn = enPlayer.Player1;

        enum enWinner { Player1, Player2, Darw, InProgress };

        struct stGameStatus
        {
            public byte PlayCount;
            public enWinner Winner;
            public bool GameOver;

        }
        stGameStatus GameStatus;

        private void FrmGame_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;

            Pen pen = new Pen(White);
            pen.Width = 15;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(pen, 510, 250, 1070, 250);
            e.Graphics.DrawLine(pen, 510, 450, 1070, 450);

            e.Graphics.DrawLine(pen, 700, 100, 700, 600);
            e.Graphics.DrawLine(pen, 900, 100, 900, 600);

        }
        private void FrmGame_Load(object sender, EventArgs e)
        {
            button1.Image = Resources.Question_Mark;
            button2.Image = Resources.Question_Mark;
            button3.Image = Resources.Question_Mark;
            button4.Image = Resources.Question_Mark;
            button5.Image = Resources.Question_Mark;
            button6.Image = Resources.Question_Mark;
            button7.Image = Resources.Question_Mark;
            button8.Image = Resources.Question_Mark;
            button9.Image = Resources.Question_Mark;

        }

        void StopGame()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";

            StopGame();

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:

                    lblWinner.Text = "Player1";

                    break;

                case enWinner.Player2:

                    lblWinner.Text = "Player2";

                    break;

                default:

                    lblWinner.Text = "Draw";
                    break;
            }

            MessageBox.Show("Game Over", "Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if ((btn1.Tag.ToString() == btn2.Tag.ToString()) && (btn2.Tag.ToString() == btn3.Tag.ToString()) && (btn1.Tag.ToString() != "?"))
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.Winner = enWinner.Player1;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }

                else
                {
                    GameStatus.Winner = enWinner.Player2;
                    GameStatus.GameOver = true;
                    EndGame();
                    return true;
                }
            }

            GameStatus.GameOver = false;
            return false;
        }

        public void CheckWinner()
        {
            if (CheckValues(button1, button2, button3))
                return;

            if (CheckValues(button4, button5, button6))
                return;

            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;

            if (CheckValues(button2, button5, button8))
                return;

            if (CheckValues(button3, button6, button9))
                return;


            if (CheckValues(button1, button5, button9))
                return;

            if (CheckValues(button3, button5, button7))
                return;

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.Winner = enWinner.Darw;
                GameStatus.GameOver = true;
                EndGame();
            }
        }

        void ChangeImage(Button btn)
        {
            if (btn.Tag.ToString() == "?")
            {
                switch (playerTurn)
                {
                    case enPlayer.Player1:
                        btn.Image = Resources.X_Letter;
                        playerTurn = enPlayer.Player2;
                        lblTurn.Text = "Player2";
                        GameStatus.PlayCount++;
                        btn.Tag = "X";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        btn.Image = Resources.O_Letter;
                        playerTurn = enPlayer.Player1;
                        lblTurn.Text = "Player1";
                        GameStatus.PlayCount++;
                        btn.Tag = "O";
                        CheckWinner();
                        break;
                }
            }

            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

         private void button_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        void ResetButton(Button btn)
        {
            btn.Enabled = true;
            btn.Image = Resources.Question_Mark;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetButton(button1);
            ResetButton(button2);
            ResetButton(button3);
            ResetButton(button4);
            ResetButton(button5);
            ResetButton(button6);
            ResetButton(button7);
            ResetButton(button8);
            ResetButton(button9);

            playerTurn = enPlayer.Player1;
            lblTurn.Text = "Player1";
            GameStatus.Winner = enWinner.InProgress;
            lblWinner.Text = "In Progress";
            GameStatus.GameOver = false;
            GameStatus.PlayCount = 0;
        }
    }
}
