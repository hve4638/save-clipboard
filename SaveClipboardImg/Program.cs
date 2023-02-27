using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace SaveClipboardImg
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string path = "";
            if (args.Length > 0 && Utils.IsValid(args[0])) path = args[0];

            if (Clipboard.ContainsImage())
            {
                Image clipboardImage = Clipboard.GetImage();

                var filename = Utils.GetPNGFileName();
                var fullPath = Utils.CombinePath(path, filename);
                clipboardImage.Save(fullPath, ImageFormat.Png);
                //Console.WriteLine($"Image saved to {fullPath}");
            }
            else
            {
                //Console.WriteLine("No image found on clipboard");
            }
        }
    }
}