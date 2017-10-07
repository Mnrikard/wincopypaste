using System;
using System.Windows.Forms;

namespace winpaste
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			Console.Write(Clipboard.GetText());
		}
	}
}
