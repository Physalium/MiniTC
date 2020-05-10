using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniTC.Model.Commands
{
    class Copy : ICommand
    {
        public string Name { get; private set; }="Copy";

        public bool Execute(string sourcePath, string targetPath)
        {
            throw new NotImplementedException();
        }


        
    }
}
