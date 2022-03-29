using System;
using System.Collections.Generic;

namespace MindFlow.Common.Models
{
    /// <summary>
    /// 键值映射
    /// </summary>
    public static class ResourcesMap
    {
        /// <summary>
        /// 各个路径
        /// </summary>
        public static Dictionary<Location, string> LocationDic = new Dictionary<Location, string>
        {
            [Location.ConfigFileName] = "GlobalConfig.json",
            [Location.GlobalConfigPath] = AppDomain.CurrentDomain.BaseDirectory + "Config\\",
            [Location.GlobalConfigFile] = AppDomain.CurrentDomain.BaseDirectory + "Config\\GlobalConfig.json",
            [Location.ModulePath] = AppDomain.CurrentDomain.BaseDirectory + "Modules"
        };
    }
}
