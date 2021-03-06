using Chess.Pieces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chess.Board
{
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
			RankFileName = GetRankFileName(rank, file);
			Piece = new King(PieceColor.White);
			LightSquare = IsLightSquare(rank, file);
		}

		private string GetRankFileName(int rank, int file)
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
			DisplayPiece(sender, args);
		}

		private void DisplayPiece(object sender, PaintEventArgs args)
		{
			if (Piece != null) Piece.DisplayPiece(sender, args);
		}

		private Color GetColor()
		{
			if (LightSquare) return Color.Wheat;
			else return Color.BurlyWood;
		}
	}
}
