namespace SaveClipboardImg
{
    public static class Utils
    {
        public static bool IsValid(string path)
        {
            return Path.IsPathRooted(path) && Path.GetInvalidPathChars().All(c => !path.Contains(c));
        }

        public static string CombinePath(string path1, string path2)
        {
            path1 = path1.Replace("/", @"\");
            path2 = path2.Replace("/", @"\");

            return Path.Combine(path1, path2);
        }

        public static string GetPNGFileName()
        {
            DateTime now = DateTime.Now;
            string formmatted = now.ToString("yyyyMMdd_HHmmss_fff");
            return $"image_{formmatted}.png";
        }
    }
}
