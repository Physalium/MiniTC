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
                dirs[i] = dirs[i].Substring(dirs[i].LastIndexOf(Path.DirectorySeparatorChar) + 1);
            }
            return dirs;
        }

        public string[] GetFiles(string path)
        {
            var files = Directory.GetFiles(path);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = files[i].Substring(files[i].LastIndexOf(Path.DirectorySeparatorChar) + 1);
            }
            return files;
        }

        public string GetParentDir(string path)
        {
            var dir = new DirectoryInfo(path);
            var rootDir = dir.Parent;
            string v = rootDir.FullName.ToString();
            return v;
        }
    }
}