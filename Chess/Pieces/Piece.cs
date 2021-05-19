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

		public void DisplayPiece(object sender, PaintEventArgs args)
		{
			throw new NotImplementedException();
		}

		public List<string> DetermineLegalMoves(List<string> PotentialPieceMoves)
		{
			return PotentialPieceMoves;
		}

	}
}
