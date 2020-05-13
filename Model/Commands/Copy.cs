using System;

namespace MiniTC.Model.Commands
{
    internal class Copy : IOperation
    {
        public string Name { get; } = "Copy";

        public bool Execute(string sourcePath, string targetPath)
        {
            throw new NotImplementedException();
        }
    }
}