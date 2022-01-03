using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace com.example.appconfig.utils
{
    public class AppConfigHelper
    {
        /// <summary>
        /// 将key,value配置值,写入app配置文件的AppSettings段.
        /// </summary>
        /// <param name="path">需要的是app的可执行文件的路径</param>
        /// <param name="keyName">不允许为空</param>
        /// <param name="keyValue"></param>
        public static void write(string path, string keyName, string keyValue)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(path);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
            foreach (string key in settings.AllKeys)
            {
                if (key == keyName)
                {
                    settings.Remove(key);
                }
            }
            settings.Add(keyName, keyValue);
            configuration.Save(ConfigurationSaveMode.Modified);
            // 对AppSetting节点进行刷新,刷新后不用重启winform程序,就可以读取到更新后的配置文件信息.
            // 注意自定义的节点不能刷新.只能重启winform程序.
            ConfigurationManager.RefreshSection("AppSettings");
        }
        /// <summary>
        /// 从app配置文件的AppSettings段,读取配置值.
        /// </summary>
        /// <param name="path">需要的是app的可执行文件的路径</param>
        /// <param name="key">如果为空,则返回空字符串</param>
        /// <returns></returns>
        public static string read(string path, string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                return "";
            }
            // 读取当前客户端app的配置文件.此配置对象会被缓存,再通过程序对配置文件进行修改,默认app读取到的还是缓存中的信息.
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(path);

            if (configuration.AppSettings.Settings[key] == null)
            {
                return "";
            }
            string value = configuration.AppSettings.Settings[key].Value;
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            return value;
        }

        /// <summary>
        /// 从app配置文件的AppSettings段,读取所有配置值.
        /// </summary>
        /// <param name="path">需要的是app的可执行文件的路径</param>
        /// <returns></returns>
        public static Dictionary<string,string> readAll(string path)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(path);
            KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
            foreach (string key in settings.AllKeys)
            {
                dictionary.Add(key, settings[key].Value);
            }
            return dictionary;
        }
    }
}
