namespace ProgramBox.Model
{
    /**
    2024.5.17 新增 Atom 类
    2024.5.17 新增 WebAtom、NativeAtom、InsAtom、WinToolAtom类
        WebAtom 
    **/
    public class Atom
    {
        // 应用名称
        public string Name;

        // 图标路径
        public string IconPath;

        // 标签
        public object Tag;

        public Atom(string name, string iconPath, string tag)
        {
            this.Name = name;
            this.IconPath = iconPath;
            this.Tag = tag;
        }

        public Atom()
        {

        }
    }


    public class WebAtom : Atom
    {
        public string Url;

        public WebAtom()
        {

        }

        public WebAtom(string name, string iconPath, string tag, string url)
            : base(name, iconPath, tag)
        {
            this.Url = url;
        }
    }

    public class NativeAtom : Atom
    {
        public string ExecPath;

        public NativeAtom(string name, string iconPath, string tag, string execPath)
            : base(name, iconPath, tag)
        {
            this.ExecPath = execPath;
        }

        public NativeAtom(string name, string execPath)
            : base(name, "", "")
        {
            this.ExecPath = execPath;
            this.IconPath = execPath;
            this.Tag = name;
        }

        public NativeAtom()
        {

        }
    }

    public class InsAtom : Atom
    {
        public string Key;

        public InsAtom(string name, string iconPath, string tag, string key)
            : base(name, iconPath, tag)
        {
            Key = key;
        }

        public InsAtom(string tag, string name)
            : base(name, "", tag)
        {
            this.IconPath = App.FullPath($"icon\\{tag}.png");
            this.Key = tag;
        }

        public InsAtom()
        {

        }
    }

    public class WinToolAtom : InsAtom
    {
        public WinToolAtom(string name, string iconPath, string tag, string key)
            : base(name, "", tag, key)
        {

        }

        public WinToolAtom(string tag, string name)
            : base(tag, name)
        {
            this.IconPath = App.FullPath($"icon\\win\\{tag}.png");
        }

        public WinToolAtom()
        {

        }
    }

}
