using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTC.Model.Commands
{
    internal interface ICommand
    {
        string Name { get; }
        bool Execute(string sourcePath, string targetPath);
    }
}
