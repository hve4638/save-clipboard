using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SaveClipboardImg
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string path = "";

            if (args.Length > 0 && Utils.IsValidPath(args[0]))
            {
                try
                {
                    SaveClipborad(path);
                }
                catch(UnauthorizedAccessException)
                {
                    MessageBox.Show("Access to this folder is denied");
                }
                
            }
        }

        static void SaveClipborad(string path)
        {
            var now = Utils.GetNowDateString();

            if (Clipboard.ContainsImage())
            {
                var image = Clipboard.GetImage();

                var filename = $"clipboard_{now}.png";
                var fullPath = Utils.CombinePath(path, filename);
                image.Save(fullPath, ImageFormat.Png);
            }
            else if (Clipboard.ContainsText())
            {
                var text = Clipboard.GetText();

                var filename = $"clipboard_{now}.txt";
                var fullPath = Utils.CombinePath(path, filename);

                using StreamWriter writer = new(fullPath);
                writer.Write(text);
            }
        }
    }
}