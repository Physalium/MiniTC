using System.Diagnostics;

using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileTreeCommands
{
    internal static class RunFile
    {
        /// <summary>
        /// Prywatna metoda addText dodająca tekst do "edytora".
        /// Metoda ta posłuży do utworzenia obiektu typu RelayCommand.
        /// </summary>
        /// <param name="param">param jest obiektem przekazywanym metodzie podczas wiązania (CommandParameter)</param>
        private static void run(object param)
        {
            TCPanelViewModel vm = param as TCPanelViewModel;
            Process.Start(vm.SelectedItem.Path);
        }

        public static RelayCommand Run
        {
            get
            {
                return new RelayCommand(argument => { run(argument); }, argument => true);
            }
        }
    }
}