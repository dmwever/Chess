using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Chess.Pieces
{
	class King : Piece
	{
		public King(PieceColor color)
		{
			Color = color;
		}
		public override void DisplayPiece(object sender, PaintEventArgs args)
		{
			Graphics graphics = args.Graphics;
			Bitmap bitmap = new Bitmap(Assembly.GetExecutingAssembly().GetManifestResourceStream("Chess.img.White King.bmp"));
			graphics.DrawImage(bitmap, 60, 60);
		}
	}
}
