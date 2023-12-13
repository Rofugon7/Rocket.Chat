using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetChangesFromLabel
{
    public class TFSFile
    {
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public string File { get; set; }

        public bool IsPackage()
        {
            return File.Contains("/Packages/");
        }
        public bool IsBody()
        {
            return IsPackage() && File.Contains(".BODY");
        }

        /// <summary>
        /// Get list of changes from a label
        /// </summary>
        public static List<TFSFile> GetLabelChanges(string strVersion)
        {
            List<TFSFile> files = new List<TFSFile>();
            try
            {
                string batFile = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "history.bat");
                System.Diagnostics.ProcessStartInfo procStartInfo =
                    new System.Diagnostics.ProcessStartInfo(batFile, "\"" + strVersion + "\"");

                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                string output = "";
                using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
                {
                    proc.StartInfo = procStartInfo;
                    proc.Start();
                    output = proc.StandardOutput.ReadToEnd();
                }
                Console.WriteLine(output);
                using (StreamReader r = new StreamReader(GenerateStreamFromString(output)))
                {
                    DateTime date = DateTime.MinValue;
                    while (!r.EndOfStream)
                    {
                        string line = r.ReadLine();
                        if (line.StartsWith("Fecha:"))
                        {
                            string strDate = line.Replace("Fecha:", "");
                            date = DateTime.Parse(strDate);
                        }
                        else if (line.Contains(".sql"))
                        {
                            int first = line.IndexOf("$");
                            string file = line.Substring(first, line.Length - first);
                            file = file.Replace("$", "C:");
                            file = file.Replace("/", "\\");

                            // Poner ruta local
                            string str1 = System.Reflection.Assembly.GetExecutingAssembly().Location;
                            str1 = str1.Substring(0, str1.IndexOf(System.Reflection.Assembly.GetEntryAssembly().GetName().Name));
                            string str2 = line.Substring(line.IndexOf("GREDOS.Oracle"));
                            file = Path.Combine(str1, str2);
                            file = file.Replace("/", "\\");
                            if (!files.Any(x => x.File == file))
                            {
                                string action = line.Substring(0, line.IndexOf(" ", 2)).Trim();
                                files.Add(new TFSFile()
                                {
                                    Action = action,
                                    Date = date,
                                    File = file
                                });
                            }
                        }
                    }
                }
            }
            catch
            {
                // Log the exception
            }
            return files;
        }

        /// <summary>
        /// String to Stream
        /// </summary>
        public static Stream GenerateStreamFromString(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str);
            MemoryStream stream = new MemoryStream();
            stream.Write(bytes, 0, bytes.Length);
            stream.Seek(0, SeekOrigin.Begin);
            return stream;
        }
    }
}
