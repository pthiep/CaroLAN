using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox Mark { get => mark; set => mark = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }

        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox mark;
        private List<List<Button>> matrix;
        #endregion

        #region Initialize

        public ChessBoardManager(Panel chessBoard, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = chessBoard;
            this.PlayerName = playerName;
            this.Mark = mark;
            this.Player = new List<Player>()
            {
                new Player("HowKTeam", Image.FromFile(Application.StartupPath + "\\Resources\\P1.png")),
                new Player("Education", Image.FromFile(Application.StartupPath + "\\Resources\\P2.png"))
            };
            CurrentPlayer = 0;
            ChangePlayer();
        }

        #endregion

        #region Methods
        public void DrawChessBoard()
        {
            Matrix = new List<List<Button>>();
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };

            for (int i = 0; i <= Contents.CHESS_BOARD_HEIGHT; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j <= Contents.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.CHESS_WIDTH,
                        Height = Contents.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };

                    btn.Click += Btn_Click;

                    chessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }

                oldBtn.Location = new Point(0, oldBtn.Location.Y + Contents.CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return;

            ChangeMark(btn);
            ChangePlayer();

            if (isEndGame(btn))
            {
                endGame();
            }
        }

        private void endGame()
        {
            MessageBox.Show("Kết thúc");
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private Point getChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);
            return point;
        }
        private bool isEndHorizontal(Button btn)
        {
            Point point = getChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Contents.CHESS_BOARD_WIDTH; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
        }
        private bool isEndVertical(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i <= Contents.CHESS_BOARD_HEIGHT; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }
            
            return countTop + countBottom == 5;
        }
        private bool isEndPrimary(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Contents.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.X + i > Contents.CHESS_BOARD_WIDTH || point.Y + i > Contents.CHESS_BOARD_HEIGHT)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private bool isEndSub(Button btn)
        {
            Point point = getChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Contents.CHESS_BOARD_WIDTH || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Contents.CHESS_BOARD_WIDTH - point.X; i++)
            {
                if (point.X - i < 0 || point.Y + i > Contents.CHESS_BOARD_HEIGHT)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        private void ChangeMark(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }

        private void ChangePlayer()
        {
            PlayerName.Text = Player[CurrentPlayer].Name;
            Mark.Image = Player[CurrentPlayer].Mark;
        }

        #endregion
    }
}
