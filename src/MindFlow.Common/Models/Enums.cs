
namespace MindFlow.Common.Models
{
    public enum Location
    {
        ConfigFileName,
        GlobalConfigPath,
        GlobalConfigFile,
        SatellitePath,
        ModulePath,
        ProcdumpPath,
        ProcdumpBatFile,
    }

    public enum MessageType
    {
        None,
        Error,
        Warning,
        Information,
        Question
    }

    public enum MessageButton
    {
        OK,
        OKCancel,
        YesNoCancel,
        YesNo
    }
}
