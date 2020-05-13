using System;
using System.Collections.Generic;

using MiniTC.Model.Commands;

namespace MiniTC.Model
{
    internal class FileOperationService
    {
        public List<IOperation> Commands = new List<IOperation>();

        public void AddCommand(IOperation command)
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

        public bool Execute(IOperation command, string sourcePath, string targetPath)
        {
            return command.Execute(sourcePath, targetPath);
        }
    }
}