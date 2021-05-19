using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	interface IPiece
	{
		PieceType type { get; }
		List<string> LegalMoves { get; set; }
		bool IsWhitePiece { get; }
		void DisplayPiece(object sender, PaintEventArgs args);
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
