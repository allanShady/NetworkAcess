using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NetworkAcessSharedFiles.Helpers
{
    public static class FileProcessor
    {
        /// <summary>
        /// Load the contents of the file. 
        /// </summary>
        /// <param name="file">File to load the contents.</param>
        /// <returns>contents as list of string.</returns>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();

        }

        /// <summary>
        /// 
        /// </summary>  
        /// <param name="fullFilePath"> e.g: \\OFFICEMANAGER\PRISERVER </param>
        /// <param name="content">The list of strings to be write on the file</param>
        /// <returns>The list of string of all contents</returns>
        public static List<string> WriteFile(this string fullFilePath, string [] content)
        {
            if (!File.Exists(fullFilePath))
            { 
                File.WriteAllLines(fullFilePath, content);
            }
            return File.ReadAllLines(fullFilePath).ToList();
        }
    }
}
