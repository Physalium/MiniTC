using System;

namespace MiniTC.Model.Commands
{
    internal class Copy : IOperation
    {
        public string Name { get; } = "Copy";

        public void Execute(string sourcePath, string targetPath)
        {
            System.IO.Directory.Move(sourcePath,targetPath); ;
        }
    }
}