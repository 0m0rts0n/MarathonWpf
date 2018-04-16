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
using System.Windows.Shapes;

namespace MarathonWpf
{
    /// <summary>
    /// Логика взаимодействия для RunnersForm.xaml
    /// </summary>
    public partial class RunnersForm : Window
    {
        public RunnersForm()
        {
            InitializeComponent();
        }

        private void ChangeBtn_Click(object sender, RoutedEventArgs e)
        {
            EditForm ef = new EditForm();
            ef.Show();
        }
    }
}
