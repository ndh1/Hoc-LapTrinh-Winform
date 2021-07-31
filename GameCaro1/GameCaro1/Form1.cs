using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro1
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(pnlChessBoard,txtPlayerName,ptcbMark);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayerMarked += ChessBoard_PlayerMarked;

            prcbCountdown.Step = Cons.COUNT_DOWN_STEP;
            prcbCountdown.Maximum = Cons.COUNT_DOWN_TIME;
            prcbCountdown.Value = 0;
            tmCountDown.Interval = Cons.COUNT_DOWN_INTERVAL ;
            NewGame();

            
        }
        void EndGame()
        {
            MessageBox.Show("Ket thuc");
            pnlChessBoard.Enabled = false;
            tmCountDown.Stop();

        }
        void NewGame()
        {
            prcbCountdown.Value = 0;
            tmCountDown.Stop();
            ChessBoard.DrawChessBoard();
           
        }
        void Undo() 
        {
        
        }
        void Quit() 
        {
           Application.Exit();
        
        }

        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {

            EndGame();

        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
           
            tmCountDown.Start();
            prcbCountdown.Value = 0;
        }

        private void tmCountDown_Tick(object sender, EventArgs e)
        {
            prcbCountdown.PerformStep();

            if (prcbCountdown.Value >= prcbCountdown.Maximum) 
            {
                tmCountDown.Stop();
                EndGame();

            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChessBoard.DrawChessBoard();
            NewGame();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }
    }
}
