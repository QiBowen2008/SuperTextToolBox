using System.Windows.Forms;

namespace SuperWenZiToolBox
{
    public static class Set
    {
        public static string INIpath = Application.StartupPath + "\\config.ini";
        public static string FileSavePath = IniManager.getString("Set", "FileSavePath", null, INIpath );
    }
}