using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Documents;
using MiniTC.Model.Commands;

namespace MiniTC.Model
{
    internal class MiniTC
    {
        #region Operations on files
        public List<ICommand> Commands;

        public void AddCommand(ICommand command)
        {
            if (!Commands.Contains(command))
            {
                Commands.Add(command);
            }
        }


        public bool ExecuteOperationByName(string name, string sourcePath, string targetPath)
        {
            foreach (var cmd in Commands)
            {
                if (cmd.Name == name) return Execute(cmd, sourcePath, targetPath);
            }
            throw new Exception("There is no command with this name.");
        }

        public bool Execute(ICommand command, string sourcePath, string targetPath)
        {
            return command.Execute(sourcePath, targetPath);
        }
        #endregion

        #region IO Methods
        public string[] GetDrives()
        {
            return Directory.GetLogicalDrives();
        }

        public string[] GetDirectories(string path)
        {
            return Directory.GetDirectories(path);
        }
        public string[] GetFiles(string path)
        {
            return Directory.GetFiles(path);
        }
        #endregion
    }
}
