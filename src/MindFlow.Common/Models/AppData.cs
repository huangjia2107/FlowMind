
namespace MindFlow.Common.Models
{
    public class AppData
    {
        public string Version { get; set; }

        public InternalData Data { get; set; } = new InternalData();
        public GlobalConfig Config { get; set; } = new GlobalConfig();
    }
}
