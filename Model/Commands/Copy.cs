using System;
using System.IO;

namespace MiniTC.Model.Commands
{
    internal class Copy : IOperation
    {
        public string Name { get; } = "Copy";

        public bool canExecute(string sourcePath, string targetPath)
        {
            string sourceDir = sourcePath.Substring(0, sourcePath.LastIndexOf(Path.DirectorySeparatorChar));
            string sourceFile = sourcePath.Substring(sourcePath.LastIndexOf(Path.DirectorySeparatorChar));
            if (sourceDir == targetPath) return false;
            return true;
        }

        public void Execute(string sourcePath, string targetPath)
        {
           
            if (File.Exists(sourcePath)) File.Copy(sourcePath, targetPath);
            if (Directory.Exists(sourcePath)) DirectoryCopy(sourcePath, targetPath, true);

        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

    }
}