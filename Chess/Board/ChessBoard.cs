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
			InitializeComponent();
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

	public class ChessSquare
	{
		const int SquareLength = 60;
		const int BoardOffset = 60;

		int Rank;
		int File;
		string RankFileName;
		IPiece Piece;
		bool LightSquare;

		public ChessSquare(int rank, int file)
		{
			Rank = rank;
			File = file;
			RankFileName = GetRankFile(rank, file);
			Piece = null;
			LightSquare = IsLightSquare(rank, file);
		}

		private string GetRankFile(int rank, int file)
		{
			StringBuilder RankFile = new StringBuilder("");
			RankFile.Append(GetRank(rank));
			RankFile.Append(file);
			return RankFile.ToString();
		}

		private char GetRank(int rank)
		{
			int ASCIIModifier = 65;
			return (char)(rank + ASCIIModifier);
		}

		private bool IsLightSquare(int rank, int file)
		{
			if (rank % 2 == file % 2) return true;
			return false;
		}

		public void DisplaySquare(object sender, PaintEventArgs args)
		{
			Color color = GetColor();
			Graphics graphics = args.Graphics;
			Brush brush = new SolidBrush(color);
			Rectangle rectangle = new Rectangle(Rank * SquareLength + BoardOffset, File * SquareLength + BoardOffset, SquareLength, SquareLength);
			graphics.FillRectangle(brush, rectangle);
		}

		private Color GetColor()
		{
			if (LightSquare) return Color.Wheat;
			else return Color.BurlyWood;
		}
	}
}
