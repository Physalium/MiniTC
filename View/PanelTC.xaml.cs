﻿using System.Windows;
using System.Windows.Controls;

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
        EventManager.RegisterRoutedEvent("PathChanged",
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
        EventManager.RegisterRoutedEvent("DriveChanged",
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
                "Drives",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );

        public static readonly RoutedEvent SelectedDriveChangedEvent =
        EventManager.RegisterRoutedEvent("SelectedDriveChanged",
                     RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                     typeof(PanelTC));

        public event RoutedEventHandler SelectedDriveChanged
        {
            add { AddHandler(SelectedDriveChangedEvent, value); }
            remove { RemoveHandler(SelectedDriveChangedEvent, value); }
        }

        private void RaiseSelectedDriveChanged()
        {
            RoutedEventArgs newEventArgs =
                    new RoutedEventArgs(SelectedDriveChangedEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty SelectedDriveProperty =
            DependencyProperty.Register(
                "SelectedDrive",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #endregion

        #region FileTree

        #region FileSelection
        public static readonly RoutedEvent FileSelectionChangedEvent =
       EventManager.RegisterRoutedEvent("FileSelectionChanged",
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
                "SelectedFile",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #endregion
        #region Contents
        public static readonly RoutedEvent ContentsChangedEvent =
      EventManager.RegisterRoutedEvent("ContentsChanged",
                   RoutingStrategy.Bubble, typeof(RoutedEventHandler),
                   typeof(PanelTC));

        public event RoutedEventHandler ContentsChanged
        {
            add { AddHandler(ContentsChangedEvent, value); }
            remove { RemoveHandler(ContentsChangedEvent, value); }
        }

        private void RaiseContentsChanged()
        {
            RoutedEventArgs newEventArgs =
                    new RoutedEventArgs(ContentsChangedEvent);
            RaiseEvent(newEventArgs);
        }

        public static readonly DependencyProperty ContentsProperty =
            DependencyProperty.Register(
                "Contents",
                typeof(string),
                typeof(PanelTC),
                new FrameworkPropertyMetadata(null)
            );
        #endregion

        #endregion

        #region Labels
        protected static readonly DependencyProperty PathLabelProperty =
            DependencyProperty.Register("PathLabel", typeof(string), typeof(PanelTC));
        protected static readonly DependencyProperty DriveLabelProperty =
            DependencyProperty.Register("DriveLabel", typeof(string), typeof(PanelTC));



        #endregion

        #endregion

        #region Dependency props
        public string Path
        {
            get { return (string)GetValue(PathProperty); }
            set { SetValue(PathProperty, value); }
        }
        public string[] Drives
        {
            get { return (string[])GetValue(DriveProperty); }
            set { SetValue(DriveProperty, value); }
        }
        public string SelectedDrive
        {
            get { return (string)GetValue(SelectedDriveProperty); }
            set { SetValue(SelectedDriveProperty, value); }
        }
        public string SelectedFile
        {
            get { return (string)GetValue(FileSelectionProperty); }
            set { SetValue(FileSelectionProperty, value); }
        }
        public string[] Contents
        {
            get { return (string[])GetValue(ContentsProperty); }
            set { SetValue(ContentsProperty, value); }
        }

        public string PathLabel
        {
            get { return (string)GetValue(PathLabelProperty); }
            set { SetValue(PathLabelProperty, value); }
        }
        public string DriveLabel
        {
            get { return (string)GetValue(DriveLabelProperty); }
            set { SetValue(DriveLabelProperty, value); }
        }
        #endregion

        #region Internal event handlers

        private void Path_TextChanged(object sender, TextChangedEventArgs e)
        {
            RaisePathChanged();
        }


        private void Contents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RaiseContentsChanged();
        }


        private void driveBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RaiseSelectedDriveChanged();
        }
        #endregion
    }
}
