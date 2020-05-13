using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MiniTC.View;
using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileTreeCommands
{
    static class OpenDir
    {
        /// <summary>
        /// Prywatna metoda addText dodająca tekst do "edytora".
        /// Metoda ta posłuży do utworzenia obiektu typu RelayCommand.
        /// </summary>
        /// <param name="param">param jest obiektem przekazywanym metodzie podczas wiązania (CommandParameter)</param>
        private static void open(object param)
        {

            TCPanelViewModel vm = param as TCPanelViewModel;
            vm.Path = vm.SelectedItem.Path;
            vm.RefreshPanel();
        }

    
        public static RelayCommand Open
        {
            get
            {
                return new RelayCommand(argument => { open(argument); }, argument => true);
            }
        }

    }
}
