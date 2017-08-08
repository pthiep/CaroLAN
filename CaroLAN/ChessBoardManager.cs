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
        #endregion

        #region Initialize

        public ChessBoardManager(Panel chessBoard)
        {
            this.ChessBoard = chessBoard;
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
                        Location = new Point(oldBtn.Location.X + oldBtn.Width, oldBtn.Location.Y)

                    };

                    chessBoard.Controls.Add(btn);

                    oldBtn = btn;
                }

                oldBtn.Location = new Point(0, oldBtn.Location.Y + Contents.CHESS_HEIGHT);
                oldBtn.Width = 0;
                oldBtn.Height = 0;
            }
        }
        #endregion
    }
}
