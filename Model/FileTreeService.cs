using System.IO;

namespace MiniTC.Model
{
    internal class FileTreeService
    {

            public string[] GetDrives()
            {
                return Directory.GetLogicalDrives();
            }

            public string[] GetDirectories(string path)
            {
            var dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                dirs[i] = dirs[i].Substring(dirs[i].LastIndexOf(Path.DirectorySeparatorChar)+1);
            }
            return dirs;
            }
            public string[] GetFiles(string path)
            {
            var files = Directory.GetDirectories(path);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(files[i].LastIndexOf(Path.DirectorySeparatorChar) + 1);
            }
            return files;
        }
 
    }
}
