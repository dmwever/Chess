using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
	interface IPiece
	{
		PieceType type { get; }
		List<string[]> LegalMoves { get; set; }
	}

	enum PieceType
	{
		Pawn,
		Knight,
		Bishop,
		Rook,
		Queen,
		King
	}
}
