
namespace MindFlow.Common.Models
{
    /// <summary>
    /// 全局配置
    /// </summary>
    public class GlobalConfig
    {
        /// <summary>
        /// 异常时生成 dump 文件
        /// </summary>
        public bool Procdump { get; set; } = false;
        public SatelliteConfig Satellite { get; set; } = new SatelliteConfig();
        public LoginConfig Login { get; set; } = new LoginConfig();
        public CommandConfig Command { get; set; } = new CommandConfig();
    }

    public class SatelliteConfig
    {
        public string FileServerIP { get; set; } = "172.16.8.187";
        public int FileServerPort { get; set; } = 9001;

        public string AllSatesFile { get; set; } = "allsates.json";
        public string CommandsFile { get; set; } = "commands.json";
        public string CommandsGroundFile { get; set; } = "commandsGround.json";
        public string EpdusFile { get; set; } = "epdusConfig.json";

        public string CurrentSateCode { get; set; }

        public string FileServerHost => $"http://{FileServerIP}:{FileServerPort}";
    }

    public class LoginConfig
    {
        public string UserName { get; set; }
        public string SystemCode { get; set; } = "ats_client";

        public string AmsServerIP { get; set; } = "127.0.0.1";
        public int AmsServerPort { get; set; } = 5000;

        public string AmsServerHost => $"http://{AmsServerIP}:{AmsServerPort}";
    }

    public class CommandConfig
    {
        public bool IsToTransfer { get; set; } = true;
        public bool IsToCanWithTcPacket { get; set; }
        public bool IsToCanWithTcFrame { get; set; }
    }
}
