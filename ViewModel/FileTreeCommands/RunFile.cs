using System.Diagnostics;

using MiniTC.ViewModel.Base;

namespace MiniTC.ViewModel.FileTreeCommands
{
    internal static class RunFile
    {
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