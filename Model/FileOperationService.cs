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

        public void ExecuteOperationByName(string name, string sourcePath, string targetPath)
        {
            foreach (var cmd in Commands)
            {
                if (cmd.Name == name) { Execute(cmd, sourcePath, targetPath); return; }
            }
            throw new Exception("There is no command with this name.");
        }

        public void Execute(IOperation command, string sourcePath, string targetPath)
        {
            command.Execute(sourcePath, targetPath);
        }
    }
}