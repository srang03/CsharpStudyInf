using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogProject
{
    public class LogLib
    {
        private string _path;
        

        public LogLib(string path)
        {
            this._path = path;
        }

        public async Task<bool> CreateLogFileAsnyc(string strLogContent)
        {
            var directoryFullPath = await Task.Run(()=> CreateDirectory());
            var result = await Task.Run(() => CreateLogOnFile(directoryFullPath, strLogContent));
            return result;
        }

        private string CreateDirectory()
        {
            string directoryFullPath = Path.Combine(_path, $"{DateTime.Now.ToString("yyyyMM")}");
            DirectoryInfo di = new DirectoryInfo(directoryFullPath);

            if (!di.Exists)
            {
                Directory.CreateDirectory(directoryFullPath);
            }
            return directoryFullPath;
        }

        private bool CreateLogOnFile(string directoryFullPath, string strLogContent)
        {
            string fileFulPath = Path.Combine(directoryFullPath, $"{DateTime.Now.ToString("yyyyMMdd")}.txt");
            FileInfo fi = new FileInfo(fileFulPath);
            string strResult = $"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")} {strLogContent}";
            try
            {
                if (!fi.Exists)
                {
                    using (StreamWriter sw = new StreamWriter(fileFulPath))
                    {
                        sw.WriteLine(strResult);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(fileFulPath))
                    {   
                        sw.WriteLine(strResult);
                        sw.Close();
                    }
                }
                return true;
            }
            catch(Exception)
            {
                return false;
            }
          
        }
    }
}
