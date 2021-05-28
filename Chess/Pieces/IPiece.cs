using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	interface IPiece
	{
		List<string> LegalMoves { get; set; }
		PieceColor Color { get; }
		void DisplayPiece(object sender, PaintEventArgs args);
	}
}
