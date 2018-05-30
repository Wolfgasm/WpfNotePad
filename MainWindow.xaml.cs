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

namespace BasicWpfNotepad
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        string filePath = "";

        public MainWindow()
        {
            InitializeComponent();
        }


        // 開啟檔案按鈕
        private void OpenBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 讀取檔案
                TextArea.Text = System.IO.File.ReadAllText(filePath);
            }
        }


        // 存檔檔案按鈕
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            // 產生開啟檔案視窗 OpenFileDialog 
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            dlg.Filter = "Text File (*.txt)|*.txt";
            // 顯示視窗
            Nullable<bool> result = dlg.ShowDialog();

            // 當按下開啟之後的反應 
            if (result == true)
            {
                // 取得檔案路徑 
                filePath = dlg.FileName;

                // 儲存檔案
                System.IO.File.WriteAllText(filePath, TextArea.Text);
            }
        }

        private void NewBtn_Click(object sender, RoutedEventArgs e)
        {
            // 重置資料

            filePath = "";
            TextArea.Text = "";
         
        }

        private void SaveAsBtn_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();

            
            dlg.Filter = "Text File (*.txt)|*.txt";

            // 防止Null
            Nullable<bool> result = dlg.ShowDialog();

            if (result == true)
            {
                filePath = dlg.FileName;
                System.IO.File.WriteAllText(dlg.FileName, TextArea.Text);
                
            }
        }

        private void FontsizeBig_click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 36;
        }

        private void FontsizeMediumn_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 24;
        }

        private void FontsizeSmall_Click(object sender, RoutedEventArgs e)
        {
            TextArea.FontSize = 12;
        }

        private void RadioBtn01_Checked(object sender, RoutedEventArgs e)
        {
           
        }

        private void RadioBtn02_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioBtnWhite_Checked(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.White;
            TextArea.Foreground = Brushes.Black;
        }

        private void RadioBtnBlack_Checked(object sender, RoutedEventArgs e)
        {
            TextArea.Background = Brushes.Gray;
            TextArea.Foreground = Brushes.White;
        }


    }
}
