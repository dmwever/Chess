using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	public abstract class Piece : IPiece
	{
		private PieceType pieceType;
		private List<string> legalMoves;
		private bool isWhitePiece;
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

		public bool IsWhitePiece
		{
			get
			{
				return isWhitePiece;
			}
		}

		public abstract void DisplayPiece(object sender, PaintEventArgs args);

		private List<string> DetermineLegalMoves(List<string> PotentialPieceMoves)
		{
			return PotentialPieceMoves;
		}

	}
}
