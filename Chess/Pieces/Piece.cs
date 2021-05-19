using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	public abstract class Piece : IPiece
	{
		private PieceType pieceType;
		private List<string> legalMoves;
		public PieceType type
		{
			get
			{
				return pieceType;
			}
		}

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

		public abstract void DisplayPiece(object sender, PaintEventArgs args);

		public List<string> DetermineLegalMoves(List<string> PotentialPieceMoves)
		{
			return PotentialPieceMoves;
		}

	}
}
