using System;
using System.Text;
using System.Windows.Forms;

namespace wincopy
{
	class Program
	{
		[STAThread]
		static void Main(string[] args)
		{
			var contentb = new StringBuilder();
			string line;
			while ((line = Console.In.ReadLine()) != null)
			{
				contentb.AppendLine(line);
			}
			string content = contentb.ToString();

			Clipboard.SetText(content);
		}
	}
}
