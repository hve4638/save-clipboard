using System.Drawing.Imaging;
using System.Security.AccessControl;
using System.Security.Principal;

namespace SaveClipboardImg
{
    public static class Utils
    {
        public static bool IsValidPath(string path)
        {
            return Path.IsPathRooted(path) && Path.GetInvalidPathChars().All(c => !path.Contains(c));
        }

        public static string CombinePath(string path1, string path2)
        {
            path1 = path1.Replace("/", @"\");
            path2 = path2.Replace("/", @"\");

            return Path.Combine(path1, path2);
        }

        public static string GetNowDateString()
        {
            return DateTime.Now.ToString("yyyyMMdd_HHmmss_fff");
        }

    }
}
