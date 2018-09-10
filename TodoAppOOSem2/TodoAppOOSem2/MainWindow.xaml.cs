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
using System.Collections.ObjectModel;

namespace TodoAppOOSem2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<TodoListItems> listitem = new ObservableCollection<TodoListItems>();

        public MainWindow()
        {
            InitializeComponent();

            TodoList.ItemsSource = listitem;
        }

        private void Btn_AddItem_Click(object sender, RoutedEventArgs e)
        {
            if (TodoText.Text != "") {
                TodoListItems todoListItems = new TodoListItems
                {
                    Item = TodoText.Text
                };
                listitem.Add(todoListItems);
            }
            TodoText.Text = "enter todo";
        }

        private void DeleteItem_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < listitem.Count; i++)
            {
                if (listitem[i].Item == TodoText.Text) {
                    listitem.RemoveAt(i);
                    //return;
                }
            }
        }

        private void BtnEditItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
