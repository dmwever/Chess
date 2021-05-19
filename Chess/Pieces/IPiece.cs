using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Chess
{
	interface IPiece
	{
		PieceType type { get; }
		List<string> LegalMoves { get; set; }
		void DisplayPiece(object sender, PaintEventArgs args);
		List<string> DetermineLegalMoves(List<string> PotentialPieceMoves);
	}

	public enum PieceType
	{
		Pawn,
		Knight,
		Bishop,
		Rook,
		Queen,
		King
	}
}
