using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Chess.Board
{
	public class ChessBoard : Form
	{
		ChessSquare [,] Squares;

		public ChessBoard()
		{
			InitializeComponent(); //Init screen
			Squares = new ChessSquare[8, 8];
			for(int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					Squares[i, j] = new ChessSquare(i, j);
				}
			}
			DisplayBoard();
		}

		public void DisplayBoard()
		{
			foreach (ChessSquare square in Squares)
			{
				this.Paint += new PaintEventHandler(square.DisplaySquare);
			}
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// ChessBoard
			// 
			this.ClientSize = new System.Drawing.Size(600, 600);
			this.Name = "ChessBoard";
			this.ResumeLayout(false);

		}
	}
}
