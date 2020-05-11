using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTC.Model.Commands
{
    class Run : ICommand
    {
        public string Name => throw new NotImplementedException();

        public bool Execute(string sourcePath, string targetPath)
        {
            throw new NotImplementedException();
        }
    }
}
