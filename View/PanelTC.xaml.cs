using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MiniTC.View
{
    /// <summary>
    /// Interaction logic for PanelTC.xaml
    /// </summary>
    /// 
    public partial class PanelTC : UserControl
    {
        public PanelTC()
        {
            InitializeComponent();
        }
        #region Events

        #region Path
        public static readonly RoutedEvent PathChangedEvent =
        EventManager.RegisterRoutedEvent("TabItemSelected",
                     RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                     typeof(PanelTC));

        public event RoutedEventHandler PathChanged
        {
            add { AddHandler(PathChangedEvent, value); }
            remove { RemoveHandler(PathChangedEvent, value); }
        }

        private void RaisePathChanged()
        {
            RoutedEventArgs newEventArgs =
                    new RoutedEventArgs(PathChangedEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register(
                "Path",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #endregion
        #region Drive
        public static readonly RoutedEvent DriveChangedEvent =
        EventManager.RegisterRoutedEvent("TabItemSelected",
                     RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                     typeof(PanelTC));

        public event RoutedEventHandler DriveChanged
        {
            add { AddHandler(DriveChangedEvent, value); }
            remove { RemoveHandler(DriveChangedEvent, value); }
        }

        private void RaiseDriveChanged()
        {
            RoutedEventArgs newEventArgs =
                    new RoutedEventArgs(DriveChangedEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty DriveProperty =
            DependencyProperty.Register(
                "Drive",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #region Contents
        public static readonly RoutedEvent FileSelectionChangedEvent =
       EventManager.RegisterRoutedEvent("TabItemSelected",
                    RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                    typeof(PanelTC));

        public event RoutedEventHandler FileSelectionChanged
        {
            add { AddHandler(FileSelectionChangedEvent, value); }
            remove { RemoveHandler(FileSelectionChangedEvent, value); }
        }

        private void RaiseFileSelectionChanged()
        {
            RoutedEventArgs newEventArgs =
                    new RoutedEventArgs(FileSelectionChangedEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty FileSelectionProperty =
            DependencyProperty.Register(
                "",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #endregion
        #endregion
        #endregion
        #region Dependency props
        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }

        #endregion

        #region Internal event handlers

        private void Path_TextChanged(object sender, TextChangedEventArgs e)
        {
            RaisePathChanged();
        }

        private void Drive_TextChanged(object sender, TextChangedEventArgs e)
        {
            RaiseDriveChanged();
        }

        private void Contents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RaiseFileSelectionChanged();
        }
        #endregion

     
    }
}
