using System.Collections.Generic;

namespace Dori16_StreamReaderReivew
{
    public class ConfigData
    {
        public string ConfigName { get; set; }
        public string ConfigPath { get; set; }
        public List<string> Directory { get; set; }
        public string Date { get; set; }
        public bool Set { get; set; }

        public ConfigData(string configName, string configPath, List<string> directory, string date, bool set)
        {
            ConfigName = configName;
            ConfigPath = configPath;
            Directory = directory;
            Date = date;
            Set = set;
        }

        public List<string> GetConfigData()
        {
            List<string> list = new List<string>();
            list.Add(ConfigName);
            list.Add(ConfigPath);
            
            foreach (var d in Directory)
            {
                list.Add(d);
            }
            list.Add(Date);
            list.Add(Set.ToString());


            return list;
        }
    }

}
