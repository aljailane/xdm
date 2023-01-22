﻿using System;
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
using Translations;

namespace XDM.Wpf.UI.Dialogs.ChromeIntegrator
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : UserControl
    {
        public Page3()
        {
            InitializeComponent();
            TxtFolder.Text = System.IO.Path.Combine(
                MsixHelper.IsAppContainer ? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) :
                AppDomain.CurrentDomain.BaseDirectory, "chrome-extension");
            this.Img.Source = new BitmapImage(
                    new Uri(
                    System.IO.Path.Combine(
                    System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images"),
                    "extension-folder.jpg")));
        }

        private void BtnCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(TxtFolder.Text);
        }

        //private void DragBorder_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (e.LeftButton == MouseButtonState.Pressed)
        //    {
        //        // MessageBox.Show("asda");
        //        var data = new DataObject();
        //        data.SetData(DataFormats.FileDrop, new string[] { System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "chrome-extension") });

        //        // Initiate the drag-and-drop operation.
        //        DragDrop.DoDragDrop(this.DragBorder, data, DragDropEffects.Copy);
        //        //DragDrop.DoDragDrop(vb,
        //        //                     "chrome://extensions",
        //        //                     DragDropEffects.Copy);
        //    }
        //}
    }
}