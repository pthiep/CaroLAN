using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroLAN
{
    public partial class Form1 : Form
    {
        #region Properties

        ChessBoardManager ChessBoard;
        SocketManager socket;

        #endregion

        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard, txtBPlayerName, picBMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            progBCoolDown.Step = Contents.COOL_DOWN_STEP;
            progBCoolDown.Maximum = Contents.COOL_DOWN_TIME;
            progBCoolDown.Value = 0;

            timerCoolDown.Interval = Contents.COOL_DOWN_INTERVAL;

            socket = new SocketManager();

            newGame();
        }

        #region Methods

        void endGame()
        {
            timerCoolDown.Stop();
            pnlChessBoard.Enabled = false;
            undoToolStripMenuItem.Enabled = false;
            MessageBox.Show("End game !!!");
        }

        void newGame()
        {
            progBCoolDown.Value = 0;
            timerCoolDown.Stop();
            undoToolStripMenuItem.Enabled = true;


            ChessBoard.DrawChessBoard();
        }

        void quitGame()
        {
            Application.Exit();
        }

        void undoGame()
        {
            ChessBoard.undoGame();
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            timerCoolDown.Start();
            progBCoolDown.Value = 0;
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            endGame();
        }

        private void timerCoolDown_Tick(object sender, EventArgs e)
        {
            progBCoolDown.PerformStep();
            if (progBCoolDown.Value >= progBCoolDown.Maximum)
            {
                endGame();
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            undoGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quitGame();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát game ?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            socket.IP = txtBIP.Text;
            if (!socket.connectServer())
            {
                socket.createServer();

                Thread listenThread = new Thread(() =>
                {
                    
                    while (true)
                    {
                        Thread.Sleep(500);
                        try
                        {
                            Listen();
                            break;
                        }
                        catch
                        {

                        }
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
            }
            else
            {
                Thread listenThread = new Thread(() =>
                {
                    Listen();
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                socket.Send("OK");
            }          

        }
        
        private void Form1_Shown(object sender, EventArgs e)
        {
            txtBIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txtBIP.Text))
            {
                txtBIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }

        void Listen()
        {
            string data = (string)socket.Receive();
            MessageBox.Show(data);
        }

        #endregion

    }
}
