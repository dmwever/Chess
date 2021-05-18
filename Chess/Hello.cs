using System;
using System.Windows.Forms;
using System.Drawing;
using Chess.Board;

namespace Chess
{
	public class Hello
	{
		

		private void f1_paint(object sender, PaintEventArgs eventArgs)
		{
			Graphics graphics = eventArgs.Graphics;
			graphics.DrawString("Hello C#", new Font("Veranda", 20), new SolidBrush(Color.Tomato), 40, 40);
			graphics.DrawRectangle(new Pen(Color.Pink, 30), 20, 20, 150, 100);
		}
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			ChessBoard chessBoard = new ChessBoard();
			Application.Run(chessBoard);
		}
	}
}
