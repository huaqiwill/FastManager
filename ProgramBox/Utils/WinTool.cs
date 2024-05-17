/**
Windows系统工具

2024.5.13 功能添加 对打开Windows系统工具进行封装
**/
namespace ProgramBox.Utils
{
    internal class WinTool
    {
        public static void openDevice()
        {
            Command.Exec("devmgmt.msc", "无法打开设备管理器");
        }

        public static void openDisk()
        {
            Command.Exec("diskmgmt.msc", "无法打开磁盘管理器");
        }

        public static void openPlannedTask()
        {
            Command.Exec("taskschd.msc", "无法打开计划任务");
        }

        public static void openRegedit()
        {
            Command.Exec("regedit.exe", "无法打开注册表");
        }

        public static void openTask()
        {
            Command.Exec("taskmgr.exe", "无法打开任务管理器");
        }

        internal static void openConfig()
        {
            Command.Exec("msconfig.exe", "无法打开系统配置工具");
        }

        internal static void openEnv()
        {
            Command.Exec("rundll32.exe sysdm.cpl,EditEnvironmentVariables", "无法打开环境变量");
        }

        internal static void openEvent()
        {
            Command.Exec("eventvwr.exe", "无法打开事件管理器");
        }

        internal static void openFirewall()
        {
            Command.Exec("wf.msc", "无法打开防火墙");
        }

        internal static void openInfo()
        {
            Command.Exec("msinfo32.exe", "无法打开系统信息");
        }

        internal static void openRes()
        {
            Command.Exec("resmon.exe", "无法打开资源管理器");
        }

        internal static void openServer()
        {
            Command.Exec("services.msc", "无法打开服务");
        }

        public static void openControl()
        {
            Command.Exec("control.exe", "无法打开控制面板");
        }

        public static void openLocalSecrity()
        {
            Command.Exec("secpol.msc", "无法打开本地安全策略");
        }

        public static void openCM()
        {
            Command.Exec("compmgmt.msc", "无法打开计算机管理工具");
        }
    }
}
