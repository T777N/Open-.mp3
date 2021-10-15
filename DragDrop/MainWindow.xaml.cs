using Microsoft.Azure.KeyVault.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;
using OpenFileDialog = System.Windows.Forms.OpenFileDialog;

namespace DragDrop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int A = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        MediaPlayer mediaPlayer = new MediaPlayer();
        string filename;

        private void iponBtn_Click(object sender, RoutedEventArgs e)
        {
            if (A == 0)
            {
                iponBtn.Margin = new Thickness(79, 351, 559, 32);
                iponBtn.Background = Brushes.DarkGreen;
                A = 1;
            }
            else if (A == 1)
            {
                iponBtn.Margin = new Thickness(49, 351, 589, 32);
                iponBtn.Background = Brushes.DarkRed;
                A = 0;
            }
        }

        private void List_MouseMove(object sender, MouseEventArgs e)
        {
            //// Get the current mouse position
            //Point mousePos = e.GetPosition(null);
            //Vector diff = startPoint - mousePos;

            //if (e.LeftButton == MouseButtonState.Pressed &&
            //    Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
            //    Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance)
            //{
            //    // Get the dragged ListViewItem
            //    ListView listView = sender as ListView;
            //    ListViewItem listViewItem =
            //        FindAnchestor<ListViewItem>((DependencyObject)e.OriginalSource);

            //    // Find the data behind the ListViewItem
            //    Contact contact = (Contact)listView.ItemContainerGenerator.
            //        ItemFromContainer(listViewItem);

            //    // Initialize the drag & drop operation
            //    DataObject dragData = new DataObject("myFormat", contact);
            //    DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (A == 1)
            {

            mediaPlayer.Pause();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (A == 1)
            {

               
            mediaPlayer.Play();

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (A == 1)
            {

            mediaPlayer.Stop();
              
            }
        }

        public void Open()
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Multiselect = false,
                DefaultExt = ".mp3"
            };
            //bool? dialogOk = fileDialog.ShowDialog();
            var dialogOk = fileDialog.ShowDialog();
            if (dialogOk != null)
            {
                filename = fileDialog.FileName;
                mp3Lbl.Content = fileDialog.SafeFileName;
                mediaPlayer.Open(new Uri(filename));

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (A == 1)
            {

            Open();
                
            }
        }

      
    }
}
