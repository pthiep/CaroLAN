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

        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox mark;

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
            Button oldBtn = new Button() { Width = 0, Location = new Point(0, 0) };

            for (int i = 0; i <= Contents.CHESS_BOARD_HEIGHT; i++)
            {
                for (int j = 0; j <= Contents.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Contents.CHESS_WIDTH,
                        Height = Contents.CHESS_HEIGHT,
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y),
                        BackgroundImageLayout = ImageLayout.Stretch                
                    };

                    btn.Click += Btn_Click;

                    chessBoard.Controls.Add(btn);

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
