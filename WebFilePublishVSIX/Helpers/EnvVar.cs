﻿namespace WebFilePublishVSIX
{
    static class EnvVar
    {
        /// <summary>
        /// 发布配置文件名字.这个文件放在项目根目录下
        /// </summary>
        public const string PublishCfgName = "publish.json";
        /// <summary>
        /// 当前要发布的项目的根路径.例如"e:/vs2017/myproject"(正斜杠,后面无/)
        /// </summary>
        public static string ProjectDir;
        
    }
}
