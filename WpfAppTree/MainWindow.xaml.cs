using System;
using System.Windows;
using System.Windows.Controls;

namespace FirstWpfApp
{
    public partial class MainWindow : Window
    {
#region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>

        public MainWindow()
        {
            InitializeComponent();
        }
#endregion

#region OnLoaded
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TreeViewItem  root=new TreeViewItem();
            TreeViewItem child = new TreeViewItem();
            root.Items.Add(child);
            FolderView.Items.Add(root);
        }
#endregion
    }
}