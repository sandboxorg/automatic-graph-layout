﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Msagl.GraphmapsWpfControl;

namespace TestGraphmaps
{
    /// <summary>
    /// Interaction logic for AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
         
        public AppWindow()
        {
            InitializeComponent();        
        }

        internal GraphmapsViewer GraphViewer { get; set; }


        public DockPanel GetMainDockPanel()
        {
            return dockPanel;
        }

        public DockPanel GetGraphViewerPanel()
        {
            return graphViewerPanel;
        }

        public TextBox GetStatusTextBox()
        {
            return statusTextBox;
        }

        //protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        //{
        //    if (e.Property.Name.Equals("ViewLayersMode"))
        //    {
        //        int x = 10;
        //    }
        //}
        void OnKeyDownHandler(object sender, KeyEventArgs e) {
            if (e.Key == Key.Return) {
                GraphViewer.FindNodeAndSelectIt(_searchBox.Text);
            }

        }

        
    }
}
