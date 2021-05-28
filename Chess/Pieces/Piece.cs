using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	public abstract class Piece : IPiece
	{
		private List<string> legalMoves;
		private PieceColor color;

		public List<string> LegalMoves
		{
			get
			{
				return legalMoves;
			}
			set
			{
				legalMoves = DetermineLegalMoves(value);
			}
		}

		public PieceColor Color
		{
			get
			{
				return color;
			}
			set
			{
				color = value;
			}
		}

		public abstract void DisplayPiece(object sender, PaintEventArgs args);

		private List<string> DetermineLegalMoves(List<string> PotentialPieceMoves)
		{
			return PotentialPieceMoves;
		}
	}
}
