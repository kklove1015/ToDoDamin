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

namespace ToDoDamin
{
    /// <summary>
    /// AddTaskWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        public DateTime? StartDate => StartDatePicker.SelectedDate;
        public DateTime? EndDate => EndDatePicker.SelectedDate;
        public string Description => DescriptionTextBox.Text;

        public AddTaskWindow()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (StartDate.HasValue && EndDate.HasValue && !string.IsNullOrEmpty(Description))
            {
                DialogResult = true;
                Close();
            }
            else 
            {
                MessageBox.Show("모든 칸을 채워주세요!","Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false; 
            Close();
        }
    }
}
