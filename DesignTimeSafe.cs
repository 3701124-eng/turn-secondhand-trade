namespace 转一转校园二手物品交易系统
{
    public static class DesignTimeSafe
    {
        public static Image? LoadImage(params string[] paths)
        {
            try
            {
                string full = Path.Combine(Application.StartupPath, Path.Combine(paths));
                if (File.Exists(full))
                    return Image.FromFile(full);
            }
            catch { }
            return null;
        }
    }
}
